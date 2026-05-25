USE SinavTakvimiOtomasyonuDB;
GO


-- TEST 1: GEÇMİŞ TARİH ENGELİ TRIGGER'I (Hata Bekleniyor)

PRINT '--- TEST 1 BAŞLIYOR ---';
BEGIN TRY
    INSERT INTO Sinavlar (DersID, Tarih, OturumID) 
    VALUES (1, '2020-01-01', 1);
END TRY
BEGIN CATCH
    PRINT 'BAŞARILI: Trigger hatayı yakaladı ve işlemi engelledi.';
    PRINT 'Hata Mesajı: ' + ERROR_MESSAGE();
END CATCH;
GO



-- TEST 2: SİLİNME LOG TRIGGER'I (Başarı Bekleniyor)

PRINT '--- TEST 2 BAŞLIYOR ---';


INSERT INTO Sinavlar (DersID, Tarih, OturumID) VALUES (1, '2026-12-31', 1);

DECLARE @SonEklenenSinavID INT = SCOPE_IDENTITY();

DELETE FROM Sinavlar WHERE SinavID = @SonEklenenSinavID;

SELECT * FROM IptalEdilenSinavlar_Log;
GO