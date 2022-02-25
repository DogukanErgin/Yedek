using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelC____
{
    class nesnetabanli
    {





        public static void Main(string[] args)
        {


            #region genel


            MyClass m1 = new MyClass();
            MyClass m2 = m1;//shallow copy
            MyClass m3 = m1.Clone(); //deep copy
            MyClass object1 = new()   //hem readonly hem de object initialize edilirken değer atanabiliyor
            {
                MyProperty = 5
            };
            MyClass object2 = new()   //hem readonly hem de object initialize edilirken değer atanabiliyor
            {
                MyProperty = 5
            };

            //object.MyProperty;//erişim yok

            MyRecord record1 = new MyRecord()
            {
                MyProperty = 3
            };
            MyRecord record2 = new MyRecord()
            {
                MyProperty = 3
            };
            MyClass object3 = object1.Clone();
            MyRecord record3 = record1 with { MyProperty = 2 };
            Console.WriteLine(Equals(record1, record2));
            Console.WriteLine(Equals(object1, object2));
            Console.WriteLine(Equals(object1, object3));
            Console.WriteLine(record3.MyProperty);
            new MyClass();
            new MyClass(4);
            new MyClass("naberr", 6);
            //SİNGLETON NESNE HEPSİ AYNI
            var database1 = Database.Instance;
            var database2 = Database.Instance;
            var database3 = Database.Instance;
            Console.WriteLine(Equals(database1, database2));
            PositionalRecord m = new PositionalRecord("Doğukan", "Ergin");
            var (n, s) = m; //deconstruct metot
            Console.WriteLine(m);
            Console.WriteLine(n);
            #endregion
            #region kalıtım

            Cocuk cocukclass = new();
            Ata ataclass = new();
            Torun torunclass = new();
            cocukclass.Y();
            ataclass.Y();
            torunclass.Y(); //kendisinden üstteki classlarda yapılan override alt sınıfları da etkiler

            A a = new C(); //çokbiçimlilik
           B b = new C();//referans classları kısıtlar b instancesinde X Y Z metotları vardır ancak B modelinden olduğu için C classının özelliklerini kullandırtmaz
            a.X();
            b.X();
            b.Y();
            #endregion
        }
        #region  destructor


        //    X();
        //    GC.Collect();
        //    Console.ReadLine();

        //}
        //static void X()
        //{
        //    MyClass m = new();
        //}
        #endregion

        //record ve object farkına gelirsek üretilmiş instanceler içindeki değerler aynı bile olsa class(objesi) farklı olduğu için false döner ancak
        //record da bu instancenin içindeki propların,fieldların değeri karşılaştırılır equals(x,y) fonksiyonu değerleri aunı ise true döner
        class MyClass
        {
            public int MyProperty { get; init; }
            /// <summary>
            /// deep copy yapılır
            /// </summary>
            /// <returns></returns>
            public MyClass Clone()
            {
                return (MyClass)this.MemberwiseClone();
            }
            public MyClass()
            {
                Console.WriteLine("1.ctor");

            }
            public MyClass(int b) : this()
            {
                Console.WriteLine($"2.ctor|{b}");
            }
            public MyClass(string a, int b) : this(b)
            {
                Console.WriteLine($"3.ctor|{a}|{b}");
            }
            ~MyClass()
            {
                Console.WriteLine("destructor...");
            }

            static MyClass()   //static constructor class modellemesi ile oluşturulan ilk nesneyle birlikte ilk çağrılır diğer nesneler ile tekrar çağrılmaz
            {    //sadece nesne üretimi ile tetiklenmez ek olarak sınıfın memberlarından static olan varsa bu işlemde de tetiklenecektir
                Console.WriteLine("myclass static constructor oluşturuldu");
            }
        }
        record MyRecord
        {
            public int MyProperty { get; set; }
        }


        class Database
        {
            private Database()
            {

            }
            static Database instance; //field
            static public Database Instance { get { return instance; } } //prop kapsülleme
            static Database() //fieldi ve static constructoru tetikler
            {
                instance = new Database();
            }
        }

        record PositionalRecord(string name, string surname)
        {

        }

        class Ata
        {
            public int  değer{ get; set; }
            private int değer2{ get; set; }
            public Ata()
            {
                Console.WriteLine($"{nameof(Ata)} nesnesi oluşturuluyor");
            }
            public Ata(int a) // eğer ki base class parametreli ise child tarafından mutlaka base ile paramatresi gönderilmelidir çünkü ilk önce Ata nesnesi heapte üretilecektir
            {
                Console.WriteLine($"parametreli olan çalıştı{a}");
            }
            public void X()
            {

            }
            public virtual void Y()
            {
                Console.WriteLine("ben ata metoduyum");
            }

        }
        class Cocuk : Ata
        {
           
            public Cocuk() : base()  // this ile class içinde constructor gezer base ile ata classın cotr larına erişebilir 
                               //boş ata ctor çağrılır
            {
                Console.WriteLine($"{nameof(Cocuk)} nesnesi oluşturuluyor");
            }
            
            public Cocuk(int b):base(b)
            {
                var değer=base.değer;
               // var değer2 = base.değer2;
            }
          public void X()  //name hiding
            {
                base.X();//ata
                X();//name hiding
            }
            public override void Y()
            {
                Console.WriteLine("ben çocuğun metoduyum");
    //Sanal yapılar ata classta olan bir algoritmayı,methodu,propu çocuklarda değiştirmek üzere kullandığımız yapılardır. yeniden tasarlandığı için o class ın fiziksel memberina
    //dönüşür kalıtım özelliği kalkar.Buna runtime da karar verilebilir.
               // base.Y();
            }
            
        }
     
        class Torun : Cocuk
        {
            public Torun()
            {
                Console.WriteLine($"{nameof(Torun)} nesnesi oluşturuluyor");
               
            }

        }

        class A
        {
            public void X()
            {

            }
        }
        class B: A
        {
            public void Y()
            {

            }
        }
        class C : B {
            public void Z()
            {

            }
        }
    }
}
