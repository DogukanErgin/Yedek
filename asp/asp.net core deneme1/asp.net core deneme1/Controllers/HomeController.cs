using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net_core_deneme1.Models;  //kitap model tanımını çağırmak için kullanılır
namespace asp.net_core_deneme1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Indexsayfasi() //tetikleme görevi index i çalıştırdığımızda oluşacak işlemler //1.adım
        {
            return View();//sayfa döndürür
        }
        public IActionResult LayoutSayfası()
        {
            return View();
        }
        public int Index3() // stringte döner aynı şekilde 6.adım
        {
            return 24;

        }
        public IActionResult KitapIndex() //8.adım 10.adım view oluşturmak
        {
            var Kitaplar = new List<Kitap>() //9.adım veritabanı niyetine
            {
                new Kitap(){ID=1,KitapAd="80 Günde Devri Alem",Yazar="Jules Verne" },
                new Kitap() {ID=2,KitapAd="Bilinmeyen Bir Kadının Mektubu",Yazar="Zweig" },
        new Kitap() {ID=3,KitapAd="Bir Noel Hikayesi",Yazar="Charles Dickens" } 
            };
            return View(Kitaplar);
        }

        public IActionResult Index6()
        {
            ViewBag.deger1 = "Merhaba Ben Core çalışıyorum";
            return View();
        }

    }
}
