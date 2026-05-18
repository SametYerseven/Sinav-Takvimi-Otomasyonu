USE SinavTakvimiOtomasyonuDB;
GO

CREATE VIEW GenelSinavProgrami
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


INSERT INTO Sinavlar (DersID, Tarih, OturumID) VALUES (1, '2026-05-20', 1);

INSERT INTO Sinav_Salonlari (SinavID, DerslikID) VALUES (1, 1); 
INSERT INTO Sinav_Salonlari (SinavID, DerslikID) VALUES (1, 2); 

INSERT INTO Gozetmen_Atamalari (AtamaID, PersonelID) VALUES (1, 1); 
INSERT INTO Gozetmen_Atamalari (AtamaID, PersonelID) VALUES (2, 2);