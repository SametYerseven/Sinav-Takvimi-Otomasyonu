USE SinavTakvimiOtomasyonuDB;
GO

-- 1.VIEW Burada genel bir sıan programı oluşturuyoruz
CREATE OR ALTER VIEW GenelSinavProgrami
AS
SELECT 
	s.Tarih,
	o.Tanim AS OturumAdi,
	o.BitisSaat,
	b.BolumAd,
	d.DersKodu,
	d.Ad AS DersAdi,
	dl.Ad AS SalonAdi,
	ISNULL(p.Unvan + ' ' + p.Ad + ' ' + p.Soyad, 'Atanmadı') AS Gozetmen

FROM Sinavlar s
INNER JOIN Dersler d ON s.DersID = d.DersID
INNER JOIN Bolumler b ON d.BolumID = b.BolumID
INNER JOIN Oturumlar o ON s.OturumID = o.OturumID
INNER JOIN Sinav_Salonlari ss ON s.SinavID = ss.SinavID
INNER JOIN Derslikler dl ON ss.DerslikID = dl.DerslikID
LEFT JOIN Gozetmen_Atamalari ga ON ss.AtamaID = ga.AtamaID
LEFT JOIN Personel p ON ga.PersonelID = p.PersonelID;
GO

-- 2.VIEW Gozetmen gorev yuku dağılımını gösteriyoruz herkese adil mi dağıtılmış bakabiliyoruz
CREATE OR ALTER VIEW GozetmenGorevYuku
AS
SELECT
 p.Unvan + ' ' + p.Ad + ' ' + p.Soyad AS PersonelAdi,
 b.BolumAd,
 COUNT(ga.GozetmenAtamaID) AS ToplamGorevSayisi

FROM Personel p
INNER JOIN Bolumler b ON p.BolumID = b.BolumID
LEFT JOIN Gozetmen_Atamalari ga ON p.PersonelID = ga.PersonelID
GROUP BY
	p.PersonelID, 
    p.Unvan, 
    p.Ad, 
    p.Soyad, 
    b.BolumAd;
GO


--3.VIEW Sınav için planlanmayan dışarıda kalan dersleri gösteriyo

CREATE OR ALTER VIEW PlanlanmayanDersler
AS
SELECT 
    d.DersKodu,
    d.Ad AS DersAdi,
    d.OgrenciSayisi,
    d.Yariyil,
    b.BolumAd
FROM Dersler d
INNER JOIN Bolumler b ON d.BolumID = b.BolumID
LEFT JOIN Sinavlar s ON d.DersID = s.DersID
WHERE s.SinavID IS NULL;
GO