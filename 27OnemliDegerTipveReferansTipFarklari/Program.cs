using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27OnemliDegerTipveReferansTipFarklari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değer tipler ( int, bool, decimal, double)  atamalar tamamen değişkene tanımlı olan değer üzerinden gerçekleşir ! 

            int sayi1 = 20;
            int sayi2 = 10;

            sayi2 = sayi1; //2. sayının değerine 1. sayının değerini atıyoruz.
            sayi1 = 1;


            Console.WriteLine(sayi2);
            Console.ReadLine();

         











            //Referans Tipler (Arrayler, string dizi tipi, Classlar, Interfaceler, Abstraclar)


            string[] sehirler1 = new string[] { "Tekirdağ", "İstanbul", "Ankara" }; // 101 diye referans nolu bir bellekte yer alır
            string[] sehirler2 = new string[] { "Antalya", "Edirne", "İzmir" }; //102 diye referans nolu bir bellekte yer alır  
            // Artık geçerli olmayan bu değerler referans üzerinden gittiği için 102 ortadan kalkıyor siler çöpe atar.


            sehirler2 = sehirler1; //  biz burada sehirler1 in referansını sehirler2 e verdik yani 2 dizi tipi içinde yeni referans değerleri 102
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            Console.ReadLine();





            // ÖRNEK 

            string[] kelimeler = new string[3] { "Tekirdağ", "İstanbul", "Ankara" };
            kelimeler = new string[4]; //yeni referans tip oluşur default değerler gelir ""

            Console.WriteLine(kelimeler[0]);
          
            
        }
    }
}
