
use Northwind
--STR�NG FONKS�YONLAR 

--LEFT :SOLDAN BEL�RT�LEN SAYIDA KARAKTER� GET�R�R

select left(adi,3) from personeller

--R�GHT SA�DAN BEL�RT�LEN KADAR KARAKTER� GET�R�R

select right(adi,3) from personeller

--UPPER B�Y�K HARFE �EV�R�R

select upper(adi) from personeller

--LOWER K���K HARFE �EV�R�R

select lower(adi) from personeller

--SUBSTR�NG : BEL�R�LEN �NDEXTEN �T�BAREN BEL�RT�LEN SAYIDA KARAKTER� GET�R�R

select SUBSTRING(soyadi,3,2) from personeller

--LTRIM: SOLDAN BO�LUKLARI KESER

Select ltrim('                 Do�ukan')

--RTRIM : SA�DAK� BO�LUKLARI KESER

select rtrim('Ergin         ')

--REVERSE :TERSE �EV�R�R

select REVERSE(adi) from Personeller

--REPLACE BEL�RT�LEN �FADEY� BEL�RT�LEN �FADE �LE DE���T�R�R


select REPLACE('do�ukan ergin','gencay','k�r�ad')

--CHARINDEX: BEL�RT�LEN KARAKTER�N VER� ���NDEK� SIRA NUMARASINI VER�R

select adi , charindex('r',adi) from personeller
select musteriadi, charindex(' ',musteriadi)from musteriler

--CHAR�NDEX �RNEK: 
-- M�STER�LER TABLOSUNUN MUSTER�AD� KOLONUNDAN SADECE ADLAR� �EKEL�M
select musteriadi from Musteriler
select SUBSTRING(musteriadi,0,charindex(' ',musteriadi)) from Musteriler

--M�STER�LER TABLOSUNUN M�STER�AD� KOLONUNDAN SADECE SOYAD�N� �EKEL�M

select SUBSTRING(musteriadi,Charindex(' ', musteriadi) , LEN(musteriadi)-(charindex(' ', Musteriadi)-1)) from Musteriler











-- pi,sin,power,abs,rand,floor gibi matematiksel fonksiyonlar vard�r


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

select KategoriID, Count(*) from  urunler     --neden �al��maz ��nk� count her bir group �d tekrar edildi�inde tekrar edecek yani birden fazla ayn� t�rde id var bunlar�n gruplanmas� laz�m

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