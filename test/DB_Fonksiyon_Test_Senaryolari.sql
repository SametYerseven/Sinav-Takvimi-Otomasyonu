SELECT dbo.OturumSuresDakika(1) AS [Oturum 1 Süresi (Dakika)];


SELECT 
    OturumID, 
    Tanim AS OturumAdi, 
    BaslangicSaat, 
    BitisSaat, 
    dbo.OturumSuresDakika(OturumID) AS [Hesaplanan Sure (Dakika)]
FROM Oturumlar;



SELECT dbo.GozetmenUcretiHesapla(1) AS [Fatih Hoca Ek Ders Ücreti];


SELECT dbo.GozetmenUcretiHesapla(4) AS [Müge Hoca Ek Ders Ücreti];


SELECT 
    p.Unvan + ' ' + p.Ad + ' ' + p.Soyad AS PersonelAdi,
    dbo.GozetmenUcretiHesapla(p.PersonelID) AS ToplamKazanilanUcret
FROM Personel p
ORDER BY ToplamKazanilanUcret DESC;