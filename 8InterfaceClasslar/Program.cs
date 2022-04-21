using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8InterfaceClasslar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Islemler islemler = new Islemler();
            //islemler.Ekleme(new Musteri { Id = 1, adi = "Samet", soyadi = "Erdem" }); // Birinci yöntem
            //Musteri musteri = new Musteri
            //{
            //    Id = 2,
            //    adi = "Özge",
            //    soyadi = "Erdem",
            //    musteriAdresi = "Hürriyet Mahallesi"
            //};
            ////İkinci yöntem
            //islemler.Ekleme(musteri); // İkinci yöntem


            //Musteri musteri2 = new Musteri();//üçüncü yöntem
            //musteri2.Id = 3;//üçüncü yöntem
            //musteri2.adi = "Ali";//üçüncü yöntem
            //musteri2.soyadi = "Erdem";//üçüncü yöntem
            //musteri2.musteriAdresi = "Hürriyet Mahallesi";//üçüncü yöntem
            //islemler.Ekleme(musteri2); // üçüncü yöntem

            //Console.WriteLine(musteri.adi);
            //Console.WriteLine(musteri2.adi);


            //Calisan calisan = new Calisan { Id = 1, adi = "Ahmet", soyadi = "Sarıkaya" };
            ////islemler.Ekleme(calisan);// Hata Neden var? - Ekleme işleminde ben müşteri istiyorum sen bana çalışan veriyorsun.
            //islemler.Ekleme2(calisan);// Hata Yok çünkü IInsan olarak tanımlanmış var? - Ekleme işleminde ortak bilgiler mevcut ve bunları istiyorum diyor


            //Kisi kisi1 = new Kisi(); // Birinci Yöntem
            //kisi1.id = 1;
            //kisi1.ad = "Samet";
            //kisi1.soyad = "Erdem";

            //Kisi kisi2 = new Kisi { id = 2, ad = "Özge", soyad = "Erdem" }; // İkinci Yöntem

            //Console.WriteLine(kisi1.ad);
            //Console.WriteLine(kisi2.ad);

            //Personel personel1 = new Personel();
            //personel1.id = 1;
            //personel1.ad = "Mahmut";
            //personel1.soyad = "Coşkun";
            //personel1.departman = "Bilgi İşlem";
            //personel1.MerhabaDe();

            //Yonetici yonetici1 = new Yonetici { id = 1, ad = "Ahmet", soyad = "Sarıkaya", yoneticiTipi = "Bilgi İşlem Müdürü" };
            //yonetici1.MerhabaDe();
            //Console.WriteLine(personel1.ad);
            //Console.WriteLine(yonetici1.ad);

            //IKisi kisi1 = new IKisi();
            //Kisi kisi3 = new Kisi();


            Calisan calisan1 = new Calisan();
            calisan1.id = 1;
            calisan1.adSoyad = "Özge Ulusoy Erdem";
            calisan1.departman = "Bilgi İşlem ";

            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.adSoyad = "Samet Erdem";
            musteri1.sirketAdi = "Sanal Yönetim Hizmetleri";

            Islemler islemler = new Islemler();
            islemler.MusteriEkleme(musteri1);
            islemler.CalisanEkleme(calisan1);

            Console.ReadLine();
        }
        class Islemler
        {
            public void MusteriEkleme(Musteri musteri)
            {
                Console.WriteLine(musteri.id + " Id li Sayın, " + musteri.adSoyad + " adına Musteri İşlemleri  Yapıldı.");
            }

            public void CalisanEkleme(Calisan calisan)
            {
                Console.WriteLine(calisan.departman+ " Departmanındaki, "+calisan.adSoyad+ " İsimli Çalışanımızın İşlemleri  Gerçekleştirildi..");
            }
        }

        interface IAdresler
        {
            string adresBilgisi { get; set; }
        }

        interface IKisi
        {
             int id { get; set; }
             string adSoyad { get; set; }

        }

        class Musteri : IKisi
        {
            public int id { get ; set ; }
            public string adSoyad { get; set; }
            public string sirketAdi { get; set; }

            public string adresBilgisi { get; set; }
        }

        class Calisan : IKisi
        {
            public int id { get; set; }
            public string adSoyad { get; set; }
            public string departman { get; set; }
            public string adresBilgisi { get; set; }
        }






        class Adres
        {
            public string aders { get; set; }
        }


        class Kisi
        {
            public int id { get; set; }
            public string ad { get; set; }
            public string soyad { get; set; }


            public void MerhabaDe()
            {
                Console.WriteLine("Merhaba");
            }

        }

        class Personel : Kisi
        {
            public string departman { get; set; }


        }


        class Yonetici : Kisi
        {
            public string yoneticiTipi { get; set; }
        }




        //interface IInsan // Baş Harfine ayrıca interface sınıfıın ilk harfi olan büyük "I" eklenir.!
        //{
        //    int Id { get; set; }
        //    string adi { get; set; }
        //    string soyadi { get; set; }

        //}

        //class Musteri : IInsan // Tanımladığımız değişkenleri tanımlamaz ise iki nokta üst üsteden sonra hata verecek! Solda Çıkan Düzelme kısmından "Ara Birimi Uygula" dediğimizde bütün değerleri set etti fakat görüntü kötü
        //{
        //    //public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //    //public string adi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //    //public string soyadi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //    public int Id { get; set; }//Interface ile gelen interface tarafında tanımlanan özellikler!
        //    public string adi { get; set; }//Interface ile gelen interface tarafında tanımlanan özellikler!
        //    public string soyadi { get; set; } //Interface ile gelen interface tarafında tanımlanan özellikler!
        //    public string musteriAdresi { get; set; } // Musterite özel tanımladığımız özellik

        //}

        //class Calisan : IInsan  
        //{
        //    public int Id { get; set; } //Interface ile gelen interface tarafında tanımlanan özellikler!
        //    public string adi { get; set; } //Interface ile gelen interface tarafında tanımlanan özellikler!
        //    public string soyadi { get; set; } //Interface ile gelen interface tarafında tanımlanan özellikler!
        //    public string departman { get; set; } // Departmana özel tanımladığımız özellik

        //}

        //class Islemler
        //{
        //    public void Ekleme(Musteri musteri)
        //    {
        //        Console.WriteLine("Eklendi"); // Gelen değerleri ektran yazdır.
        //    }
        //    public void Ekleme2(IInsan musteri)
        //    {
        //        Console.WriteLine("Eklendi"); // Gelen değerleri ekrana yazdır.
        //    }
        //}


    }
}
