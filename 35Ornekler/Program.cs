using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler=new Islemler();

            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            var kisiler= islemler.islem(sayi);


            foreach (Kisiler kisi in kisiler)
            {
                Console.Write("AdSoyad: {0} , Yaş: {1}, Cinsiyet: {2}", kisi.AdSoyad, kisi.Yas, kisi.Cinsiyet);
                if (kisi.Cinsiyet == "Erkek")
                {
                    if (kisi.Askerlik == "Yapıldı" || kisi.Askerlik == "Muaf")
                    {
                        Console.WriteLine("Askerlik: {0} , Askerliği engeli yok,", kisi.Askerlik);
                    }
                    else
                    {
                        Console.WriteLine("Askerlik: {0} , Tecil: {1} sonra askerlik yapacak,", kisi.Askerlik, kisi.Yil);
                    }

                }
            }


            //Console.WriteLine(islemler.Ornek1(20, 1, "Çarpma"));
            //Console.ReadLine();



            //islemler.Ornek2(70, "Samet Erdem");
            //Console.ReadLine();



            //islemler.Ornek3();

            //Console.WriteLine("Lütfen 1 sayı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Lütfen 2 sayı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //islemler.Ornek4(sayi1, ref sayi2);
            //Console.WriteLine(sayi2);



            // islemler.Ornek5();

            // islemler.Ornek6();




            Console.ReadLine();
        }
    }

}
