USE SinavTakvimiOtomasyonuDB;
GO

-- 1.Stored Procedures: Kendisi sınav salonlarını atayarak kontrol yapar

CREATE OR ALTER PROCEDURE SinavVeAkilliSalonAtama
	@p_DersID INT,
	@p_Tarih DATE,
	@p_OturumID INT
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @KalanOgrenci INT;
	SELECT @KalanOgrenci = OgrenciSayisi FROM Dersler WHERE DersID = @p_DersID;

	IF @KalanOgrenci IS NULL
	BEGIN 
		PRINT 'HATA: Belirtilen DersID bulunamadı.';
		REtURN;
	END


	DECLARE @YeniSinavID INT;
	INSERT INTO Sinavlar (DersID,Tarih, OturumID)
	VALUES (@p_DersID, @p_Tarih, @p_OturumID);

	SET @YeniSinavID = SCOPE_IDENTITY();

	DECLARE @SecilenDerslikID INT;
	DECLARE @Kapasite INT;

	DECLARE crs_Salonlar CURSOr FOR
	SELECT DerslikID, Kapasite
	FROM Derslikler
	WHERE Aktif = 1
		AND DerslikID NOT IN (
			SELECT ss.DerslikID
			FROM Sinav_Salonlari ss
			INNER JOIN Sinavlar s ON ss.SinavID = s.SinavID
			WHERE s.Tarih = @p_Tarih AND s.OturumID = @p_OturumID
		)
	ORDER BY Kapasite DESC;

	OPEN crs_Salonlar;
	FETCH NEXT FROM crs_Salonlar INTO @SecilenDerslikID, @Kapasite;

	WHILE @@FETCH_STATUS = 0 AND @KalanOgrenci > 0 
	BEGIN
		INSERT INTO Sinav_Salonlari (SinavID, DerslikID)
		VALUES (@YeniSinavID, @SecilenDerslikID);

		SET @KalanOgrenci = @KalanOgrenci - @Kapasite;

		FETCH NEXT FROM crs_Salonlar INTO @SecilenDerslikID, @Kapasite;
    END

    CLOSE crs_Salonlar;
    DEALLOCATE crs_Salonlar;

	IF @KalanOgrenci > 0
    BEGIN
        PRINT 'DİKKAT: Sınav atandı ancak müsait salon kalmadığı için ' + CAST(@KalanOgrenci AS NVARCHAR) + ' öğrenci açıkta kaldı!';
    END
    ELSE
    BEGIN
        PRINT 'BAŞARILI: Sınav oluşturuldu ve tüm öğrenciler kapasiteye göre salonlara yerleştirildi.';
    END
END;
GO


-- 2.Stored Procedures: Görevli olan hoıcanın aynı saate başka sınav ile çakışması var mı diye kontrol eder

CREATE OR ALTER PROCEDURE GozetmenAta
    @p_AtamaID INT,
    @p_PersonelID INT
AS
BEGIN
    SET NOCOUNT ON;

	DECLARE @HedefTarih DATE;
    DECLARE @HedefOturum INT;

    SELECT @HedefTarih = s.Tarih, @HedefOturum = s.OturumID
    FROM Sinav_Salonlari ss
    INNER JOIN Sinavlar s ON ss.SinavID = s.SinavID
    WHERE ss.AtamaID = @p_AtamaID;

	IF EXISTS (
        SELECT 1 
        FROM Gozetmen_Atamalari ga
        INNER JOIN Sinav_Salonlari ss ON ga.AtamaID = ss.AtamaID
        INNER JOIN Sinavlar s ON ss.SinavID = s.SinavID
        WHERE ga.PersonelID = @p_PersonelID 
          AND s.Tarih = @HedefTarih 
          AND s.OturumID = @HedefOturum
    )
    BEGIN
        PRINT 'HATA: Bu gözetmen aynı tarih ve oturumda başka bir sınıfa atanmış durumda.';
        RETURN;
    END

	INSERT INTO Gozetmen_Atamalari (AtamaID, PersonelID) 
    VALUES (@p_AtamaID, @p_PersonelID);
    
    PRINT 'BAŞARILI: Gözetmen ataması sorunsuz şekilde yapıldı.';
END;
GO


-- 3.Stored Procedures: İptal edilmek ya da silinmek istenen sınavı güvenli bir şekilde silmemizi sağlar

CREATE OR ALTER PROCEDURE SinavIptalEt
    @p_SinavID INT
AS
BEGIN
    SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 FROM Sinavlar WHERE SinavID = @p_SinavID)
    BEGIN
        PRINT 'HATA: İptal edilmek istenen SinavID veritabanında bulunamadı.';
        RETURN;
    END

	DELETE FROM Gozetmen_Atamalari 
    WHERE AtamaID IN (SELECT AtamaID FROM Sinav_Salonlari WHERE SinavID = @p_SinavID);

	DELETE FROM Sinav_Salonlari 
    WHERE SinavID = @p_SinavID;

	DELETE FROM Sinavlar 
    WHERE SinavID = @p_SinavID;

    PRINT 'BAŞARILI: Sınav ve bu sınava bağlı tüm salon/gözetmen kayıtları güvenle silindi.';
END;
GO


-- 4.Stored Procedures: Sınavın yapılacağı derslik kapatılmak istenirse 
-- planlanmış sınav varmı diye kontrol eder ve duruma göre dersliği günceller.

CREATE OR ALTER PROCEDURE sp_DerslikGuncelle
    @p_DerslikID INT,
    @p_YeniAd NVARCHAR(50),
    @p_YeniKapasite INT,
    @p_Aktif BIT
AS
BEGIN
    SET NOCOUNT ON;

    IF @p_Aktif = 0 AND EXISTS (
        SELECT 1 
        FROM Sinav_Salonlari ss
        INNER JOIN Sinavlar s ON ss.SinavID = s.SinavID
        WHERE ss.DerslikID = @p_DerslikID AND s.Tarih >= GETDATE()
    )
    BEGIN
        PRINT 'HATA: Bu salonda planlanmış sınavlar var. Salonu kapatılamaz. Sınavları kaydırmanız gerekli.';
        RETURN;
    END

    UPDATE Derslikler
    SET 
        Ad = @p_YeniAd,
        Kapasite = @p_YeniKapasite,
        Aktif = @p_Aktif
    WHERE DerslikID = @p_DerslikID;

    PRINT 'BAŞARILI: Salon bilgileri başarıyla güncellendi.';
END;
GO



--5.Stored Procedures: BONUS olan ve veritabanının yedeğini alıp kayıt eden SP


CREATE OR ALTER PROCEDURE VeritabaniYedekle
    @p_YedekYolu NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @DosyaAdi NVARCHAR(700);
    DECLARE @TarihEtiketi NVARCHAR(50);

    IF RIGHT(@p_YedekYolu, 1) <> '\'
    BEGIN
        SET @p_YedekYolu = @p_YedekYolu + '\';
    END

    SET @TarihEtiketi = FORMAT(GETDATE(), 'yyyyMMdd_HHmmss');
    SET @DosyaAdi = @p_YedekYolu + 'SinavTakvimiDB_' + @TarihEtiketi + '.bak';

    BEGIN TRY
        
        BACKUP DATABASE SinavTakvimiOtomasyonuDB
        TO DISK = @DosyaAdi
        WITH FORMAT, INIT, 
        NAME = 'Sinav Takvimi Otomasyonu Full Backup';

        PRINT 'BAŞARILI: Veritabanı yedeği belirtilen konuma alındı!';
        PRINT 'Dosya: ' + @DosyaAdi;
    END TRY
    BEGIN CATCH
        PRINT 'HATA: Yedekleme başarısız oldu.';
        PRINT 'Sistem Hata Mesajı: ' + ERROR_MESSAGE();
    END CATCH
END;
GO