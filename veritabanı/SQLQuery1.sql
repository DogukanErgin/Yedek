
use Northwind
--STRÝNG FONKSÝYONLAR 

--LEFT :SOLDAN BELÝRTÝLEN SAYIDA KARAKTERÝ GETÝRÝR

select left(adi,3) from personeller

--RÝGHT SAÐDAN BELÝRTÝLEN KADAR KARAKTERÝ GETÝRÝR

select right(adi,3) from personeller

--UPPER BÜYÜK HARFE ÇEVÝRÝR

select upper(adi) from personeller

--LOWER KÜÇÜK HARFE ÇEVÝRÝR

select lower(adi) from personeller

--SUBSTRÝNG : BELÝRÝLEN ÝNDEXTEN ÝTÝBAREN BELÝRTÝLEN SAYIDA KARAKTERÝ GETÝRÝR

select SUBSTRING(soyadi,3,2) from personeller

--LTRIM: SOLDAN BOÞLUKLARI KESER

Select ltrim('                 Doðukan')

--RTRIM : SAÐDAKÝ BOÞLUKLARI KESER

select rtrim('Ergin         ')

--REVERSE :TERSE ÇEVÝRÝR

select REVERSE(adi) from Personeller

--REPLACE BELÝRTÝLEN ÝFADEYÝ BELÝRTÝLEN ÝFADE ÝLE DEÐÝÞTÝRÝR


select REPLACE('doðukan ergin','gencay','kürþad')

--CHARINDEX: BELÝRTÝLEN KARAKTERÝN VERÝ ÝÇÝNDEKÝ SIRA NUMARASINI VERÝR

select adi , charindex('r',adi) from personeller
select musteriadi, charindex(' ',musteriadi)from musteriler

--CHARÝNDEX ÖRNEK: 
-- MÜSTERÝLER TABLOSUNUN MUSTERÝADÝ KOLONUNDAN SADECE ADLARÝ ÇEKELÝM
select musteriadi from Musteriler
select SUBSTRING(musteriadi,0,charindex(' ',musteriadi)) from Musteriler

--MÜSTERÝLER TABLOSUNUN MÜSTERÝADÝ KOLONUNDAN SADECE SOYADÝNÝ ÇEKELÝM

select SUBSTRING(musteriadi,Charindex(' ', musteriadi) , LEN(musteriadi)-(charindex(' ', Musteriadi)-1)) from Musteriler











-- pi,sin,power,abs,rand,floor gibi matematiksel fonksiyonlar vardýr


--GETDATE , DATEADD   , DATEDIFF   ,   DATEPART

select dateadd(day,999,getdate())

select datediff(MONTH, '21.02.2002' , getdate())

select datepart(month,getdate())






--top komutu

select top 3 * from Personeller


--distinct 

select distinct sehir from personeller

--group by

select *from urunler

select KategoriID, Count(*) from  urunler     --neden çalýþmaz çünkü count her bir group ýd tekrar edildiðinde tekrar edecek yani birden fazla ayný türde id var bunlarýn gruplanmasý lazým

select KategoriID, Count(*) from  urunler group by KategoriID     

select personelID,  sum(NakliyeUcreti) from satislar group by PersonelID 

select personelID,  sum(NakliyeUcreti) from satislar where NakliyeUcreti>50  group by PersonelID 

select KategoriID, Count(*) from  urunler where KategoriID>5  group by KategoriID  having count(*)>6



-----   inner join

select * from personeller p inner join satislar s on p.PersonelID=s.PersonelID

select UrunID,KategoriAdi from Urunler u inner join Kategoriler k on u.KategoriID=k.KategoriId

select count(u.UrunAdi) from Urunler u inner join Kategoriler k on u.KategoriID=k.KategoriId where KategoriAdi='Beverages' 

select u.urunadi from kategoriler k inner join urunler u on k.KategoriID=u.KategoriID where k.KategoriAdi='seafood'

select s.satisID,p.adi+' ' +p.soyadi [personel] from Satislar s inner join Personeller p on s.PersonelID=p.PersonelID 