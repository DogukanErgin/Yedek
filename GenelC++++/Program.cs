//using Microsoft.Extensions.Primitives;
//using System;
//using System.Text;

//namespace GenelC____
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int yas = 33;
//            string mesaj = yas < 25 ? "yas 25 den küçük" : (yas == 25 ? "yas 25" : "yas 25 den büyük");
//            Console.WriteLine(mesaj);

//            string ad = "Ergin";
//            //string ad = null;
//            Console.WriteLine(ad ?? "nulldur");
//            string x = null;
//            Console.WriteLine(x ??= "merhaba");
//            Console.WriteLine(x);
//            int? id = null;
//            id ??= 1;

//            int i = 10;
//            string mesajj = i switch
//            {
//                5 when 3 == 3 => "5tir",
//                var xx when xx == 7 && xx % 2 == 1 => "8dir",
//                10 => "10dur",
//                var xx => "hiçbiri"//default
//            };
//            Console.WriteLine(mesajj);



//            #region menu
//            //bool devam = true;

//            //while (devam)
//            //{
//            //    {

//            //        Console.WriteLine("Enter Customer Details (s) ");
//            //        Console.WriteLine("Enter usage data (u) ");
//            //        Console.WriteLine("Display usage data (d) ");

//            //        string menu = Console.ReadLine();

//            //        switch (menu)
//            //        {
//            //            case "s":
//            //                Console.WriteLine("s");
//            //                break;

//            //            case "u":
//            //                Console.WriteLine("u");
//            //                break;

//            //            case "d":
//            //                Console.WriteLine("d");
//            //                break;

//            //            default:
//            //                Console.WriteLine("zq");
//            //                devam = false;

//            //                break;
//            //        }
//            //    }
//            //}
//            #endregion


//            int h = 5;
//            if (!(h > 8))
//            {
//                Console.WriteLine("deneme");
//            }

//            #region örnek1
//            ////int ürün1 = int.Parse(Console.ReadLine());
//            ////int ürün2 = Convert.ToInt32(Console.ReadLine());
//            ////if (ürün1 + ürün2 > 200)
//            ////    Console.WriteLine("indirimsiz tutar" + (ürün1 + ürün2));
//            ////{
//            ////    ürün2 = ürün2 * 3 / 4;
//            ////    Console.WriteLine("indirimli tutar" + (ürün1 + ürün2));
//            ////}
//            #endregion

//            #region  örnek2

//            //string s1=Console.ReadLine(), s2=Console.ReadLine();
//            //string mesajjj = (s1, s2) switch
//            //{
//            //    ("gncy", "yıldız") => "helal başarılı",
//            //    _ => "hatalı girdiniz"
//            //};
//            //Console.WriteLine(mesajjj);
//            #endregion

//            #region örnek3
//            //double sayı1 = int.Parse(Console.ReadLine());
//            //double sayı2 = int.Parse(Console.ReadLine());
//            //string işlemtürü = Console.ReadLine();
//            //if (işlemtürü == "+")
//            //{
//            //    Console.WriteLine("Toplamları" + (sayı1 + sayı2));
//            //}
//            //if (işlemtürü == "-")
//            //{
//            //    Console.WriteLine("farkı" + (sayı1 - sayı2));
//            //}
//            //if (işlemtürü == "*")
//            //{
//            //    Console.WriteLine("çarpım" + (sayı1 * sayı2));
//            //}
//            //if (işlemtürü == "/")
//            //{
//            //    Console.WriteLine("bölüm" + (sayı1 / sayı2));
//            //}
//            //string sonuc = işlemtürü switch
//            //{
//            //    "+" => Convert.ToString(sayı1 + sayı2),
//            //    "-" => Convert.ToString(sayı1 - sayı2),
//            //    "*" => Convert.ToString(sayı1 * sayı2),
//            //    "/" => Convert.ToString(sayı1 / sayı2),
//            //    _=>"geçersiz işlem"
//            //};
//            //Console.WriteLine(sonuc);

//            //Console.WriteLine(işlemtürü ==  "+" ?sayı1+sayı2 :(işlemtürü=="-"?sayı1-sayı2:(işlemtürü=="*"?sayı1*sayı2:(işlemtürü=="/"? sayı1/sayı2:"gecersiz"))));
//            #endregion

//            #region örnek4
//            //int sayı = Convert.ToInt32(Console.ReadLine());
//            //if (sayı != 10)

//            //    Console.WriteLine("wrong number");
//            //Console.WriteLine(sayı==10?"":"yanlış");
//            #endregion

//            object y = 152;
//            if (y is int ya)
//                Console.WriteLine(ya + 8);
//            object yy = "TR";
//            if (yy is var varyy)    //türü runtime da belirlenir  normalde direkt derlenirken bürünür *var*
//                Console.WriteLine(varyy);

//            bool resultt = y is string yyyy;
//            // Console.WriteLine(yyyy); // null olabilir çünkü unboxing sonrası obje y string olmayabilir
//            bool result = y is var yyy;
//            Console.WriteLine(yyy);  //runtime da karar kılınır type ' ına 

//            Array array = Array.CreateInstance(typeof(int), 5);

//            var dizi = new[] { 5, 2, 1, 5, 7, 8, 3, 8, 0, 3, 3, 7, 2, 24, 7};
//            Index index = 5;
//            Index index2 = ^2;
//            Range range = 3..8; //dizinin belirli bir aralığını kopyalar kendisi de dizidir
//            var range2 = dizi[range];  //range2 dizidir

//            Console.WriteLine(dizi[index]);
//            Console.WriteLine(dizi[index2]);
//            Console.WriteLine(range2[3]);

//            int tcNo = 236313641;
//            Console.WriteLine($"Tcno {tcNo}"); //string interplation
           
//            string massage= @$"
//                deneme{tcNo}    
//                yapıyorum bakalım {tcNo}
//                nasıl gidioyor";
//            Console.WriteLine(massage);

//            #region örnek5
//            //string adSoyad = "Doğukan Ergin";
//            //Index ilkten3 = 2;
//            //Index sondan5 = ^5;
//            //Console.WriteLine(adSoyad[ilkten3]);
//            //Console.WriteLine(adSoyad[sondan5]);

//            //string METİN = Console.ReadLine();
//            //int count = 0;
//            //for (int z = 0; z < METİN.Length; z++)
//            //{
//            //    if (METİN[z] == 'n')
//            //        count++;

//            //}
//            //Console.WriteLine(count);
//            //string[] dizi2 = METİN.Split(" ");
//            //Console.WriteLine(dizi2.Length);
//            #endregion


//            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70 };
//            ArraySegment<int> segment = new ArraySegment<int>(sayilar);
//            ArraySegment<int> segment2 = new ArraySegment<int>(sayilar,2,4);
//            ArraySegment<int> segment21 = segment.Slice(2, 4); 


//            //aynı dizi üzerinde işlemler gerçekleşir
//            segment[2] *= 4;
//            segment2[0] *= 7;
//            Console.WriteLine(sayilar[2]);
            
//            StringSegment segments = new StringSegment(ad,1,3);
     
//            Console.WriteLine(segments);

//            //String birleştirmede + yerine az maaliyet için
//            StringBuilder builder = new StringBuilder();
//            builder.Append(ad);
//            builder.Append(" ");
//            builder.Append(massage);
//            Console.WriteLine(builder.ToString());
//            Span<int> span = new Span<int>(sayilar);



//        }
//    }
//}



