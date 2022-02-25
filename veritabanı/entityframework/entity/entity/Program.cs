using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    class Program
    {

        static void Main(string[] args)
        {
            #region blabla


            //NorthwindEntities db = new NorthwindEntities();
            //var ürünler = db.Fiyati_En_Yuksek_On_Urun();
            //foreach (var  ürün in ürünler)

            //{

            //    Console.WriteLine(ürün.TenMostExpensiveUrunler+" / "+ürün.BirimFiyati); //store prodecure
            //}
            //var satislar = db.Yillik_Satislar(new DateTime(1998 , 1 ,1),DateTime.Now);
            //foreach (var satis in satislar)

            //{

            //    Console.WriteLine(satis.SevkTarihi+"    ////    "+satis.SatisID); //store prodecure
            //}
            //var isim = db.Musteriler;
            //foreach (var item in isim)
            //{
            //    Console.WriteLine(item.MusteriAdi);
            //}

            //Console.ReadLine();
            #endregion

            #region CRUD

            //NorthwindEntities db = new NorthwindEntities();
            ////nesne createlemek için ne lazım önce o classtan bir nesne oluşturmak ardından propları doldurup db üzerine bu dolu nesneyi göndermek gerekir
            //var nakliyeciler= new Nakliyeciler();
            //nakliyeciler.NakliyeciID = 2867;
            //nakliyeciler.SirketAdi = "ergin company";
            //nakliyeciler.Telefon = "58349068340967";
            //db.Nakliyeciler.Add(nakliyeciler);
            //db.SaveChanges(); //böyle yapmazsak heapte tutulur



            ////nesne okumak için db deki tüm tabloyu koleksiyon olarak tutacak bir değişkene atayıp ondan sonra bu koleksiyonu foreach ile dönüp istediğimiz değerleri okuruz
            //var nakliyecilerread = db.Nakliyeciler;
            //foreach (var nakliye in nakliyecilerread)
            //{
            //    Console.WriteLine(nakliye.SirketAdi);
            //}

            ////update etmek için db deki key ile tüm tablo elemanlarını alabiliriz ve bunu bir değişkene atayarak üzerindeki elemanlara erişebiliriz
            //var nakliyeupdate = db.Nakliyeciler.Find(4);
            //nakliyeupdate.SirketAdi = "erginnn company";
            //db.SaveChanges();


            //// silmek için ise tablodan key ile elemanı bulup fonksiyonlar ile sileriz
            //var nakliyedelete = db.Nakliyeciler.Find(5);
            //db.Nakliyeciler.Remove(nakliyedelete);
            //db.SaveChanges();
            //Console.ReadLine();

            #endregion


            #region sorgular

            //NorthwindEntities db = new NorthwindEntities();
            //var tablo1 = db.Nakliyeciler;
            //ConsoleTable.From(tablo1).Write();

            //var tablo2 = db.Nakliyeciler.Select(x => new
            //{
            //    ID = x.NakliyeciID,
            //    Tlfn = x.Telefon
            //});

            ////var tablo2 = from table in db.Nakliyeciler select new {
            ////    ID = table.NakliyeciID,
            ////    telefon=table.Telefon

            ////}; //LINQ 
            //ConsoleTable.From(tablo2).Write();


            //var tablo3 = db.Nakliyeciler.Take(2);
            //ConsoleTable.From(tablo3).Write();

            //var tablo4 = db.Nakliyeciler.OrderBy(x => x.SirketAdi);//bu lambda expression this keywordu gibi düşün
            //ConsoleTable.From(tablo4).Write();


            //var tablo5 = db.Nakliyeciler.Where(x => x.NakliyeciID > 3);
            //ConsoleTable.From(tablo5).Write();
            //var tablo6 = db.Nakliyeciler.Where(x => x.SirketAdi.Contains("er")); //contains startswith endwith leri kullanıyoruz
            //ConsoleTable.From(tablo6).Write();

            //var tablo7 = from m in db.Musteriler   //inner join
            //             join n in db.Nakliyeciler on m.SirketAdi equals n.SirketAdi
            //             orderby m.PostaKodu descending
            //             select new
            //             {
            //                 m.Sehir,
            //                 n.SirketAdi
            //             };

            //var tablo8 = from m in db.Musteriler      //group by
            //             group m by m.Sehir into x
            //             select new
            //             {
            //                 x.Key,
            //                 numberofcity = x.Count()
            //             };
            //ConsoleTable.From(tablo8).Write();
            //Console.ReadLine();

            #endregion

            //1000+1 N+1 problem nedir foreach ile döndürme işlemi yaptığımızda her bir döngü için sorgu çalıştırır ki bu oldukça fazla oluyor lazy loading yüzünden olur
            #region thenby skip take all any single first
            NorthwindEntities db = new NorthwindEntities();
            var tablo1 = db.Musteriler.OrderBy(x => x.Sehir).ThenBy(x=>x.Sehir).Select(x => new {   //bu biraz yanlış oldu ama 2  tarafta sıralanacaksa kullanılır
            x.MusteriID,
            x.Sehir
            });
      ConsoleTable.From(tablo1).Write();
            var tablo2 = db.Musteriler.OrderBy(x => x.Sehir).Skip(3).Take(2).Select(x => new
            {
                x.MusteriID,
                x.Sehir,
                x.MusteriAdi
            });
                ConsoleTable.From(tablo2).Write();
            var y = "Palle Ibsen";
            var result = db.Musteriler.Single(x=>x.MusteriAdi ==y);  //singleordefault ta ise hiç eleman yoksa null döndürür single de hata alır ve birden fazla eleman varsada
            var sehir = result.Sehir;                                //ikisi birden  hata verir
            Console.WriteLine(sehir);
            Console.ReadLine();

            var result2 = db.Musteriler.First(x=>x.MusteriID=="1"); //musteriid si 1 olan ilk kişiyi alır
            #endregion
        }
    }
}
