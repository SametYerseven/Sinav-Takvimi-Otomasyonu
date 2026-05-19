USE SinavTakvimiOtomasyonuDB;
GO

-- 1.Fonskiyon: sınav saatinin süresini otomatik olarak dakikaya çeviren fonkisyon

CREATE OR ALTER FUNCTION OturumSuresDakika(@p_OturumID INT)
RETURNS INT
AS
BEGIN
	DECLARE @SureDakika INT;

	SELECT @SureDakika = DATEDIFF(MINUTE, BaslangicSaat, BitisSaat)
	FROM Oturumlar
	WHERE OturumID = @p_OturumID;

	RETURN @SureDakika;
END;
GO

-- 2.Fonskiyon: Gözetmenlerin sınav başına aldıkları ek ücreti hesaplama fonskiyonu

CREATE OR ALTER FUNCTION GozetmenUcretiHesapla(@p_PersonelID INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @ToplamGorevSayisi INT;
    DECLARE @BirimUcret DECIMAL(10,2) = 450.00; 
    DECLARE @ToplamKazanc DECIMAL(10,2);

    SELECT @ToplamGorevSayisi = COUNT(GozetmenAtamaID)
    FROM Gozetmen_Atamalari
    WHERE PersonelID = @p_PersonelID;

    SET @ToplamKazanc = @ToplamGorevSayisi * @BirimUcret;

    RETURN ISNULL(@ToplamKazanc, 0); 
END;
GO