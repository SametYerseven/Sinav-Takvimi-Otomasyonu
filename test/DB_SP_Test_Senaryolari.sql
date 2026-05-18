USE SinavTakvimiOtomasyonuDB;
GO

EXEC SinavVeAkilliSalonAtama 
    @p_DersID = 2, 
    @p_Tarih = '2026-05-25', 
    @p_OturumID = 3;


SELECT * FROM GenelSinavProgrami;

EXEC GozetmenAta 
    @p_AtamaID = 3, 
    @p_PersonelID = 3;

EXEC GozetmenAta 
    @p_AtamaID = 4,
    @p_PersonelID = 3;


SELECT * FROM GozetmenGorevYuku ORDER BY ToplamGorevSayisi DESC;


EXEC sp_DerslikGuncelle 
    @p_DerslikID = 3, 
    @p_YeniAd = 'Lab-1 (Güncel)', 
    @p_YeniKapasite = 40, 
    @p_Aktif = 1;

EXEC sp_DerslikGuncelle 
    @p_DerslikID = 1, 
    @p_YeniAd = 'Amfi-1', 
    @p_YeniKapasite = 70, 
    @p_Aktif = 0;


EXEC SinavIptalEt 
    @p_SinavID = 2;

SELECT * FROM GenelSinavProgrami;