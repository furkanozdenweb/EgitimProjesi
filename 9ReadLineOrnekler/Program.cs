using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9ReadLineOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 adet parametre alan ve bunların toplamlarını geri döndüren ve Ana methodumuzun içinde ekrana yazan bir uygulama.

            //int sonuc = ToplaUcSayi(23, 44, 644);
            //Console.WriteLine(sonuc);
            //Console.ReadLine();




            // "Hoşgeldin, Samet Erdem"<< 2 Adet parametre alan (Ad, Soyad) ve bu parametrelerdeki string değerli ekrana yazdıran uygulama.
            Console.WriteLine("Lütfen Adınızı Giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen Soyadınızı Giriniz");
            string soyad = Console.ReadLine();
            HosgeldinEkranaYaz(ad, soyad);
            Console.ReadLine();

        }

        static void HosgeldinEkranaYaz(string adi, string soyadi)
        {
            Console.WriteLine("Hoşgeldin, " + adi + " " + soyadi);
        }

        static int ToplaUcSayi(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = sayi1 + sayi2 + sayi3;
            return sonuc;
        }



    }
}
