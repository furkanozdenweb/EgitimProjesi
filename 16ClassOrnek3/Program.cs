using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ClassOrnek3
{

    class MusteriIslemleri
    {
        public void KasaIslem(string musteriAdi, int UrunSayisi)
        {
            string urunAdi;
            int urunFiyat;
            int toplamFiyat=0;
            string urunListele = "";
            for(int i=1;i<= UrunSayisi;i++)
            {
                Console.WriteLine("{0} Ürün Adı Giriniz", i);
                urunAdi = Console.ReadLine();
                Console.WriteLine("{0} Ürün Fiyat Giriniz",i);
                urunFiyat = Convert.ToInt32(Console.ReadLine());
                toplamFiyat += urunFiyat;
                urunListele += i + ". Ürün Adı:"+ urunAdi +" Fiyat "+ urunFiyat+"TL\n";
            }
            Console.WriteLine("Sayın: {0}", musteriAdi);
            Console.WriteLine(urunListele);
            Console.WriteLine("Aldığınız {0} adet ürünün toplam fiyatı: {1}tl dir.",  UrunSayisi, toplamFiyat);
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Müşteri Adı Giriniz:");
            string musteriAdi = Console.ReadLine();
            Console.WriteLine("Müşteri Satın Aldığı Ürün Sayısı Giriniz:");
            int aldigiUrunSayisi = Convert.ToInt32(Console.ReadLine());

            MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
            musteriIslemleri.KasaIslem(musteriAdi, aldigiUrunSayisi);

            // MüsteriIslemleri classı altında birr method oluşturulacak. Method 2 adet parametre alacak 1. parametre isim 2. parametre aldığı ürün sayısı

            // Her Bir Ürün için için
            // 1 Müşteri aldığı 1. ürün adı
            // 2 Müşteri aldığı 1. ürün fiyatı

            //  Ürünlerin toplam fiyatını hesaplayacak ve ekrana 


            //  "Sayın 'Adı' 'Soyadı' 
            //  Aldığınız 1. Ürün: 'Kitap 60Tl'  
            //  Aldığınız 2. Ürün: 'Masa 260Tl' 
            //  Toplam Sipariş tutarınız: 320TL'dir.

        }
    }
}
