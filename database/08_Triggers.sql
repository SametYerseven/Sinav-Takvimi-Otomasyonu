USE SinavTakvimiOtomasyonuDB;
GO


IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'IptalEdilenSinavlar_Log')
BEGIN
    CREATE TABLE IptalEdilenSinavlar_Log (
        LogID INT IDENTITY(1,1) PRIMARY KEY,
        EskiSinavID INT,
        DersID INT,
        Tarih DATE,
        OturumID INT,
        IptalZamani DATETIME DEFAULT GETDATE(), 
        IptalEdenKullanici NVARCHAR(100) DEFAULT SYSTEM_USER 
    );
END
GO


-- TRIGGER 1: SİLİNEN SINAVLARI OTOMATİK LOGLAMA (AFTER DELETE)

CREATE OR ALTER TRIGGER trg_SinavSilinmeLog
ON Sinavlar
AFTER DELETE
AS
BEGIN

    INSERT INTO IptalEdilenSinavlar_Log (EskiSinavID, DersID, Tarih, OturumID)
    SELECT SinavID, DersID, Tarih, OturumID
    FROM deleted;
    
    PRINT 'SİSTEM BİLGİSİ (Trigger): Silinen sınav başarıyla Log tablosuna yedeklendi.';
END;
GO


-- TRIGGER 2: GEÇMİŞ TARİHE SINAV EKLENMESİNİ ENGELLEME (AFTER INSERT, UPDATE)

CREATE OR ALTER TRIGGER trg_GecmisTarihEngel
ON Sinavlar
AFTER INSERT, UPDATE
AS
BEGIN

    IF EXISTS (SELECT 1 FROM inserted WHERE Tarih < CAST(GETDATE() AS DATE))
    BEGIN

        RAISERROR ('GÜVENLİK İHLALİ (Trigger): Geçmiş bir tarihe sınav planlanamaz veya güncellenemez!', 16, 1);
        
        ROLLBACK TRANSACTION; 
    END
END;
GO