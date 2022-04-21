using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Classlar
{

    class Musteri
    {
        public void FiyatHesapla2Urun()
        {

            Console.WriteLine("Müşteri adı giriniz");
            string adSoyad = Console.ReadLine();

            Console.WriteLine("Ürün 1 adı giriniz");
            string urun1Ad = Console.ReadLine();

            Console.WriteLine("Ürün 1 fiyat giriniz");
            int urun1Fiyat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ürün 2 adı giriniz");
            string urun2Ad = Console.ReadLine();

            Console.WriteLine("Ürün 2 fiyat giriniz");
            int urun2Fiyat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoşgeldiniz, Sayın {0}", adSoyad);
            Console.WriteLine("Aldığınız 1. Ürün: '{0} {1}Tl'", urun1Ad, urun1Fiyat);
            Console.WriteLine("Aldığınız 2. Ürün: '{0} {1}Tl'", urun2Ad, urun2Fiyat);
            Console.WriteLine("Toplam Sipariş tutarınız: " + (urun1Fiyat + urun2Fiyat) + " TL dir.");
            Console.ReadLine();

        }
    }


    class Program
    {
      

        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.FiyatHesapla2Urun();

            //MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
            //musteriIslemleri.VeritabaninaEkle();
            //int sonuc= musteriIslemleri.Toplama(4, 7);
            //Console.WriteLine(sonuc);

            //MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
            //musteriIslemleri.KayitYap();x
            //Console.WriteLine("Değer 1 Giriniz");
            //string deger1 = Console.ReadLine();
            //Console.WriteLine("Değer 2 Giriniz");
            //string deger2 = Console.ReadLine();
            //musteriIslemleri.ToplamaYap(Convert.ToInt32(deger1), Convert.ToInt32(deger2));

            //Console.ReadLine();
            //UrunUIslemleri urunIslemleri = new UrunUIslemleri();
            //urunIslemleri.ToplamaYap(5, 8);

            //Musteri musteri1 = new Musteri();
            //musteri1.Ad = "Samet";
            //musteri1.Id = 1;
            //musteri1.Soyad = "Erdem";
            //musteri1.Sehir = "Tekirdağ";

            //Musteri musteri2 = new Musteri
            //{
            //    Id=2, Ad="Ahmet", Soyad="Sarikaya",Sehir="İstanbul"
            //};
            //Console.ReadLine();





        }
    }







    class MusteriIslemleri
    {
        public int Toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void VeritabaninaEkle()
        {
            Console.WriteLine("Veritabanına veriler yazdırıldı.");
        }

        public void VeritabanindanSil()
        {
            Console.WriteLine("Veritabanından veriler silindi.");
        }

        public void VeritabaninıGuncelle()
        {
            Console.WriteLine("Veritabanından veriler silindi.");
        }
    }



















    class MusteriIslemleri2
    {
        public void KayitYap()
        {
            Console.WriteLine("Kayıt İşlemi Yapıldı.");
        }

        public void KayitGuncelleme()
        {
            Console.WriteLine("Güncelleme İşlemi Yapıldı.");
        }

        public void KayitSilme()
        {
            Console.WriteLine("Silme İşlemi Yapıldı.");
        }

        public void ToplamaYap(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        public void CikartmaYap(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
