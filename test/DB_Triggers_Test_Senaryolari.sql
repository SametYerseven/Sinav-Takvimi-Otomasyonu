USE SinavTakvimiOtomasyonuDB;
GO

-- ==========================================================
-- SENARYO 4: TETİKLEYİCİLERİN (TRIGGERS) TEST EDİLMESİ
-- Bu dosya, sistemdeki tetikleyicilerin (otomatik işlemlerin) 
-- doğru çalışıp çalışmadığını test etmek için oluşturulmuştur.
-- ==========================================================

-- ----------------------------------------------------------
-- TEST 1: GEÇMİŞ TARİH ENGELİ TRIGGER'I (Hata Bekleniyor)
-- ----------------------------------------------------------
-- Senaryo: Bugünün tarihinden eski bir güne (Örn: 2020 yılına) sınav eklemeye çalışalım.
-- Beklenen: Trigger uyanmalı, kırmızı hata vermeli ve sınavın eklenmesini engellemeli!

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

-- ----------------------------------------------------------
-- TEST 2: SİLİNME LOG TRIGGER'I (Başarı Bekleniyor)
-- ----------------------------------------------------------
PRINT '--- TEST 2 BAŞLIYOR ---';

-- 1. Önce geleceğe yalandan bir test sınavı ekleyelim
INSERT INTO Sinavlar (DersID, Tarih, OturumID) VALUES (1, '2026-12-31', 1);

-- 2. Aynı işlem bloğunda eklenen son ID'yi yakalayalım
DECLARE @SonEklenenSinavID INT = SCOPE_IDENTITY();

-- 3. Şimdi o eklediğimiz sınavı silelim
DELETE FROM Sinavlar WHERE SinavID = @SonEklenenSinavID;

-- 4. Kontrol: Biz sadece DELETE dedik ama Trigger arka planda bu silinen sınavı Log tablosuna kaydetti mi?
SELECT * FROM IptalEdilenSinavlar_Log;
GO