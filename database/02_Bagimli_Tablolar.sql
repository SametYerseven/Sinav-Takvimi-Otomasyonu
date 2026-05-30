USE SinavTakvimiOtomasyonuDB;
GO

CREATE TABLE Personel(
	PersonelID INT IDENTITY(1,1) PRIMARY KEY,
	Unvan NVARCHAR(70),
	Ad NVARCHAR(50),
	Soyad NVARCHAR(50),
	BolumID INT NOT NULL,

	CONSTRAINT Personel_Bolumler FOREIGN KEY (BolumID)
	REFERENCES Bolumler(BolumID)
);
GO

CREATE TABLE Dersler (
	DersID INT IDENTITY(1,1) PRIMARY KEY,
	DersKodu NVARCHAR(20) NOT NULL,
	DersTuru NVARCHAR(20),
	Ad NVARCHAR(100) NOT NULL,
	OgrenciSayisi INT NOT NULL,
	Yariyil INT NOT NULL,
	BolumID INT NOT NULL,

	CONSTRAINT Dersler_Bolumler FOREIGN KEY (BolumID)
	REFERENCES Bolumler(BolumID)
);
GO

-- SİSTEM GİRİŞİ İÇİN KULLANICILAR TABLOSU
CREATE TABLE Kullanicilar (
    KullaniciID INT IDENTITY(1,1) PRIMARY KEY,
    PersonelID INT UNIQUE NOT NULL, 
    KullaniciAdi NVARCHAR(50) UNIQUE NOT NULL, 
    Sifre NVARCHAR(100) NOT NULL, 
    Rol NVARCHAR(20) DEFAULT 'Gozetmen', 
    Durum BIT DEFAULT 1, 
    
    CONSTRAINT FK_Kullanicilar_Personel FOREIGN KEY (PersonelID) 
    REFERENCES Personel(PersonelID)
);
GO

-- TEST VERİLERİ (Arayüzde giriş yapmak için 2 adet hesap)
INSERT INTO Kullanicilar (PersonelID, KullaniciAdi, Sifre, Rol)
VALUES (1, 'admin', 'admin123', 'Yonetici');

INSERT INTO Kullanicilar (PersonelID, KullaniciAdi, Sifre, Rol)
VALUES (2, 'ahmet_hoca', '1234', 'Gozetmen');
GO