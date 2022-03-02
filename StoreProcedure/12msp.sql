Go
CREATE TABLE StokBilgi (SiraNo INT,IslemTur NVARCHAR(5),EvrakNo VARCHAR(16),Tarih VARCHAR(15),GirisMiktar NUMERIC(25,6),CikisMiktar Numeric(25,6),StokMiktar Numeric(25,6))
go
CREATE OR ALTER   PROCEDURE [dbo].[Deneme](@mal_Kodu VARCHAR(50)=NULL,@bas_tarih INT=NULL, @bit_tarih INT=NULL)
AS
BEGIN


INSERT INTO StokBilgi(SiraNo,IslemTur,EvrakNo,Tarih,GirisMiktar,CikisMiktar,StokMiktar)
SELECT
ROW_NUMBER() OVER (ORDER BY Tarih) AS SiraNo,
CASE si.IslemTur
    WHEN 0 THEN 'Giriþ'
    WHEN 1 THEN 'Çýkýþ'
END AS IslemTuru,
si.EvrakNo,
CONVERT(VARCHAR(15), CAST(si.Tarih - 2 AS datetime), 23) AS Tarih,
CAST(CASE si.IslemTur
    WHEN 0 THEN Miktar
WHEN 1 THEN 0
END AS int)AS GirisMiktar,
CAST(CASE si.IslemTur
    WHEN 0 THEN 0
WHEN 1 THEN Miktar
END AS int) AS CikisMiktar,
0 AS StokMiktari
FROM STI si INNER JOIN STK sk ON si.MalKodu = sk.MalKodu
WHERE si.MalKodu = @mal_Kodu AND si.Tarih BETWEEN @bas_tarih AND @bit_tarih;
DECLARE @Stok NUMERIC(25,2)
DECLARE @sirano int;
DECLARE @islemtur VARCHAR(5);
DECLARE @evrakno VARCHAR(16);
DECLARE @tarih VARCHAR(50);
DECLARE @girismiktar INT;
DECLARE @cikismiktar INT;
DECLARE @stokmiktari INT=0;

DECLARE p_RC CURSOR FOR
SELECT SiraNo,IslemTur,EvrakNo,Tarih,GirisMiktar,CikisMiktar,StokMiktar FROM StokBilgi
OPEN p_RC;

FETCH NEXT FROM p_RC INTO

@sirano,
@islemtur,
@evrakno,
@tarih,
@girismiktar,
@cikismiktar,
@Stok;

WHILE @@FETCH_STATUS = 0

BEGIN

IF(@islemtur = 'Giriþ')
BEGIN
SET @stokmiktari = @stokmiktari + @girismiktar;
END
ELSE
BEGIN

SET @stokmiktari = @stokmiktari - @cikismiktar;
END
UPDATE StokBilgi 
SET Stokmiktar = @stokmiktari
WHERE SiraNo=@sirano


FETCH NEXT FROM p_RC INTO
@sirano,
@islemtur,
@evrakno,
@tarih,
@girismiktar,
@cikismiktar,
@Stok;

END


SELECT * FROM STI
TRUNCATE TABLE StokBilgi
CLOSE p_RC  
DEALLOCATE p_RC

END

