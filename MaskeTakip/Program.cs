using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip
{
    class Program
    {
        private static readonly object person1;

        static void Main(string[] args, PttManager pttManager)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Arda");
            SelamVer(isim: "Osman");
            SelamVer(isim: "Umut");
            SelamVer();

            int sonuc = Topla(3, 5);

            //Diziler / Arrays
            string ogreni1 = "Arda";
            string ogreni2 = "Berra";
            string ogreni3 = "Elif";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Arda";
            ogrenciler[1] = "Batuhan";
            ogrenciler[2] = "Elif";
            //ogrenviler[3] = "ilker";
            ogrenciler = new string[4];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new string[] { "Ankara, İstanbul, İzmir" };
            string[] sehirler2 = new string[] { "Antalya, Bursa, Manisa" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine("sehir");
            }

            List<string> yeniSehirler = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler.Add("Adana 1");
            foreach (var sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }
            new PttManager(new ForeignerManagar()).GiveMask(person1);
            pttManager.GiveMask(person1 );


            Console.ReadLine();
        }
        static void SelamVer(string isim = "isimsiz")
        {

            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {

            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }


        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Arda";
            string soyad = "Aslan";
            int dogumyili = 2007;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }

    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Dogumyili { get; }
        public long TcNo { get; set; }


    }
}
