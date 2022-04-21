using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Soru : İlk gün 20 sayfa kitap okuyan bir insan her gün 15 sayfa okuyarak 900 sayfalık bir kitabı kaç günde bitirir.
            //int gun = 1;
            //int okunanSayfa = 20;
            //int kitapSayfaSayisi = 900;

            //while (okunanSayfa <= kitapSayfaSayisi)
            //{
            //    gun++;
            //    okunanSayfa = okunanSayfa + 15;
            //}
            //Console.WriteLine(gun);




            //// 2. Soru : cümlenin sonunda "?" var ise ekrana bu bir soru cümlesi, yok ise bu bir soru cümlesi değil yazan program.
            //string cumle = "Yarın kurs var mı?";
            //bool soruIsaretiVarmi = cumle.EndsWith("?");

            //if (cumle.EndsWith("?"))
            //{
            //    Console.WriteLine("Bu bir soru  cümlesi.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu bir soru  cümlesi değil.");
            //}
            //Console.ReadLine();


            //3.Soru : İlk gün 20 sayfa kitap okuyan bir insan her gün 15 sayfa okuyarak 900 sayfalık bir kitabı kaç günde bitirir.


            //int gun2 = 1;
            //int okunanSayfa2 = 20;
            //Console.WriteLine(gun2 + ". Gün Okunan Toplam Sayfa: " + okunanSayfa2);
            //int kitapSayfaSayisi2 = 900;

            //while (okunanSayfa2 <= kitapSayfaSayisi2)
            //{
            //    gun2++;
            //    okunanSayfa2 = okunanSayfa2 + 15;
            //    Console.WriteLine(gun2 + ". Gün Okunan Toplam Sayfa: " + okunanSayfa2);
            //}
            //Console.WriteLine("Kitabın bittiği gün: " + gun2 + " Okunan Toplam Sayfa: " + kitapSayfaSayisi2);
            //Console.ReadLine();


            //2 Adet Parametre değer alacak. PArametrelerden bir tanesi "Her gün okunan sayfa sayısı", diğeri ise "Kitabın tolam sayfa sayısı" her gün belirlenen sayfa  sayısı kadar okuyarak belirlenen kitap sayfa sayısını kaç günde bitirir.

            //int herGunOkunanSayfaSayisi = 23;
            //int kitapToplamSayfaSayisi = 500;


            //KitapKacGundeBiter(herGunOkunanSayfaSayisi, kitapToplamSayfaSayisi);


            //Soru Klavyeden girilen 10 adet sayının toplamını ekrana yazan uygulama.

            //Ornek1While();


            // Ornek1For();


            // 5 adet girilen sayıdan en büyüğünü ekrana yazdıran program


            int enBuyukSayi=0;
            int gelenDeger;
            for(int i=1; i <= 5; i++)
            {
                Console.WriteLine("{0}. Sayıyı giriniz.",i);
                gelenDeger = Convert.ToInt32(Console.ReadLine());
                if(gelenDeger > enBuyukSayi)
                {
                    enBuyukSayi = gelenDeger;
                }
            }
            Console.WriteLine(enBuyukSayi);






            Console.ReadLine();


        }

        private static void Ornek1For()
        {
            int sonuc = 0;
            int gelenDeger;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz", i);
                gelenDeger = Convert.ToInt32(Console.ReadLine());
                sonuc = sonuc + gelenDeger;

            }
            Console.WriteLine(sonuc);
        }
        private static void Ornek1While()
        {
            int sonuc = 0;
            int sayi = 1;
            int gelenDeger;
            while (sayi <= 10)
            {
                Console.WriteLine("{0}. Sayı yı Giriniz", sayi);
                gelenDeger = Convert.ToInt32(Console.ReadLine());
                sonuc = sonuc + gelenDeger;
                sayi++;
            }
            Console.WriteLine(sonuc);
        }

        static void KitapKacGundeBiter(int herGunOkunanSayfaSayisi,int KitapToplamSayfa)
        {
            // 1. Soru : İlk gün 20 sayfa kitap okuyan bir insan her gün 15 sayfa okuyarak 900 sayfalık bir kitabı kaç günde bitirir.
            int gun = 0;
            int okunanToplamSayfa = 0;
            while (okunanToplamSayfa<= KitapToplamSayfa)
            {
                okunanToplamSayfa = okunanToplamSayfa + herGunOkunanSayfaSayisi;
                gun++;
            }
            Console.WriteLine(gun);

        }
    }
}
