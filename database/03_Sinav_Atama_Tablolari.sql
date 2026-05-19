USE SinavTakvimiOtomasyonuDB
GO

CREATE TABLE Personel_Durum (
	DurumID INT IDENTITY(1,1) PRIMARY KEY,
	PersonelID INT NOT NULL,
	Tarih DATE NOT NULL,
	MazeretTuru NVARCHAR(100),
	Uygun BIT DEFAULT 0,

	CONSTRAINT PersonelDurum_Personel FOREIGN KEY (PersonelID)
	REFERENCES Personel(PersonelID)
);

CREATE TABLE Sinavlar (
	SinavID INT IDENTITY(1,1) PRIMARY KEY,
	DersID INT NOT NULL,
	Tarih DATE NOT NULL,
	OturumID INT NOT NULL,

	CONSTRAINT Sinavlar_Dersler FOREIGN KEY (DersID)
	REFERENCES Dersler(DersID),

	CONSTRAINT Sinavlar_Oturumlar FOREIGN KEY (OturumID)
	REFERENCES Oturumlar(OturumID)
);

CREATE TABLE Sinav_Salonlari (
	AtamaID INT IDENTITY(1,1) PRIMARY KEY,
	SinavID INT NOT NULL,
	DerslikID INT NOT NULL,

	CONSTRAINT SinavSalonlari_Sinav FOREIGN KEY (SinavID)
	REFERENCES Sinavlar(SinavID),

	CONSTRAINT SinavSalonlari_Derslik FOREIGN KEY (DerslikID)
	REFERENCES Derslikler(DerslikID)
);

CREATE TABLE Gozetmen_Atamalari (
	GozetmenAtamaID INT IDENTITY(1,1) PRIMARY KEY,
	AtamaID INT NOT NULL,
	PersonelID INT NOT NULL,

	CONSTRAINT GozetmenAtamalari_Atama FOREIGN KEY (AtamaID)
	REFERENCES Sinav_Salonlari(AtamaID),

	CONSTRAINT GozetmenAtamalari_Personel FOREIGN KEY (PersonelID)
	REFERENCES Personel(PersonelID)
);



