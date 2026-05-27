USE SinavTakvimiOtomasyonuDB;
GO

-- 1.Fonskiyon: sınav saatinin süresini otomatik olarak dakikaya çeviren fonkisyon

CREATE OR ALTER FUNCTION OturumSuresDakika(@p_OturumID INT)
RETURNS INT
AS
BEGIN
	DECLARE @SureDakika INT;

	SELECT @SureDakika = DATEDIFF(MINUTE, BaslangicSaat, BitisSaat)
	FROM Oturumlar
	WHERE OturumID = @p_OturumID;

	RETURN @SureDakika;
END;
GO

-- 2.Fonskiyon: Gözetmenlerin sınav başına aldıkları ek ücreti hesaplama fonskiyonu

CREATE OR ALTER FUNCTION GozetmenUcretiHesapla(@p_PersonelID INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @ToplamGorevSayisi INT;
    DECLARE @BirimUcret DECIMAL(10,2) = 450.00; 
    DECLARE @ToplamKazanc DECIMAL(10,2);

    SELECT @ToplamGorevSayisi = COUNT(GozetmenAtamaID)
    FROM Gozetmen_Atamalari
    WHERE PersonelID = @p_PersonelID;

    SET @ToplamKazanc = @ToplamGorevSayisi * @BirimUcret;

    RETURN ISNULL(@ToplamKazanc, 0); 
END;
GO

USE SinavTakvimiOtomasyonuDB;
GO




-- UDF 3: DERSLİK MÜSAİTLİK DURUMU KONTROLÜ

CREATE OR ALTER FUNCTION dbo.fn_DerslikMusaitlik(
    @p_DerslikID INT,
    @p_Tarih DATE,
    @p_OturumID INT
)
RETURNS NVARCHAR(20)
AS
BEGIN
    DECLARE @Durum NVARCHAR(20);

    IF EXISTS (
        SELECT 1
        FROM Sinav_Salonlari ss
        INNER JOIN Sinavlar s ON ss.SinavID = s.SinavID
        WHERE ss.DerslikID = @p_DerslikID
          AND s.Tarih = @p_Tarih
          AND s.OturumID = @p_OturumID
    )
    BEGIN
        SET @Durum = 'Dolu';
    END
    ELSE
    BEGIN
        SET @Durum = 'Müsait';
    END

    RETURN @Durum;
END;
GO