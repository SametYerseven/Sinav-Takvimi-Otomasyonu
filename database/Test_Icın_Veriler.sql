USE SinavTakvimiOtomasyonuDB
GO

INSERT INTO Bolumler (BolumAd) VALUES
('Yazılım Mühendisliği'),
('Makine Mühendisliği'),
('Mekatronik Mühendisliği'),
('Enerji Sistemleri Mühendisliği'),
('Elektrik Mühendisliği');

INSERT INTO Oturumlar (Tanim, BaslangicSaat, BitisSaat) VALUES
('Oturum-1', '09:00', '10:30'),
('Oturum-2', '10:30', '12:00'),
('Oturum-3', '12:00', '13:30'),
('Oturum-4', '13:45', '15:15'),
('Oturum-5', '14:00', '15:30');

INSERT INTO Derslikler (Ad, Kapasite, Tip, Aktif) VALUES
('Amfi-1', 70, 'Amfi', 1),
('Z-04', 70, 'Sınıf', 1),
('Lab-1', 30, 'Lab', 1);

INSERT INTO Personel (Unvan, Ad, Soyad, BolumID) VALUES
('Prof. Dr.', 'Fatih', 'Hoca', 1), 
('Doç. Dr.', 'Tuğba', 'Hoca', 1),
('Dr. Öğr.', 'Güney', 'Hoca', 1),
('Arş. Gör.', 'Müge', 'Hoca', 2);

INSERT INTO Dersler (DersKodu, DersTuru, Ad, OgrenciSayisi, Yariyil, BolumID) VALUES
('YZM2126', 'Zorunlu', 'Veritabanı Sistemlerine Giriş', 132, 4, 1);