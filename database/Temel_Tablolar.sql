USE SinavTakvimiOtomasyonuDB;
GO

CREATE TABLE Bolumler (
    BolumID INT IDENTITY(1,1) PRIMARY KEY,
    BolumAd NVARCHAR(100) NOT NULL
);

CREATE TABLE Oturumlar (
    OturumID INT IDENTITY(1,1) PRIMARY KEY,
    Tanim NVARCHAR(50) NOT NULL,
    BaslangicSaat TIME NOT NULL,
    BitisSaat TIME NOT NULL
);

CREATE TABLE Derslikler (
    DerslikID INT IDENTITY(1,1) PRIMARY KEY,
    Ad NVARCHAR(50) NOT NULL,
    Kapasite INT NOT NULL,
    Tip NVARCHAR(50), 
    Aktif BIT DEFAULT 1 
);