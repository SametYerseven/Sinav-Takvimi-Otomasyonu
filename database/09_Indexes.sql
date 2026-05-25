USE SinavTakvimiOtomasyonuDB;
GO

-- INDEX 1: SINAV ARAMA PERFORMANSI (COMPOSITE INDEX)
CREATE NONCLUSTERED INDEX IX_Sinavlar_TarihOturum 
ON Sinavlar (Tarih, OturumID);
GO


-- INDEX 2: PERSONEL (GÖZETMEN) ARAMA PERFORMANSI
CREATE NONCLUSTERED INDEX IX_Personel_AdSoyad 
ON Personel (Ad, Soyad);
GO

PRINT 'BAŞARILI: Performans indeksleri veritabanına eklendi.';
GO