using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14InterfaceClasslarKullanimOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel(); //Yöntem 1
            personel1.Id = 1;
            personel1.Adi = "Samet";
            personel1.Soyadi = "Erdem";
            Personel personel2 = new Personel { Id=2, Adi="Özge", Soyadi="Erdem", Departman="Yazılım"}; //Yöntem 2

            PersonelIslemleri personelIslemleri = new PersonelIslemleri();
            personelIslemleri.Ekleme(new Personel { Adi = "Ege", Soyadi = "Erdem", Id = 3, Departman = "Ana Sınıfı" });


            Ogrenci ogrenci = new Ogrenci(); //Yöntem 1
            ogrenci.Id = 1;
            ogrenci.Adi = "Samet";
            ogrenci.Soyadi = "Erdem";
            Ogrenci ogrenci2 = new Ogrenci { Id = 2, Adi = "Özge", Soyadi = "Erdem", Sinif = "Yazılım" }; //Yöntem 2
            personelIslemleri.Ekleme(new Ogrenci { Adi = "Ege", Soyadi = "Erdem", Id = 3, Sinif = "Ana Sınıfı" });

            Console.ReadLine();
        }

        interface IInsan
        {
             int Id { get; set; } 
             string Adi { get; set; }
             string Soyadi { get; set; }


        }

        class Personel : IInsan
        {
            public string Departman { get; set; }  
            public int Id { get; set ; }
            public string Adi { get; set; }
            public string Soyadi { get ; set; }
        }

        class Ogrenci : IInsan
        {
            public int Id { get; set;}
            public string Adi { get; set;}
            public string Soyadi { get; set;}
            public string Sinif { get; set; }
        }
            // Yeni bir sınıf ekle Müşteri  diye.. Örnek olsun

        class PersonelIslemleri // Alttaki farkı methodlar aynı işlemi yapıyor ama 2 sine gerek yok.!
        {
            public void Ekleme(Personel personel) // Bir Ekleme methodu ekliyoruz  ve buna Ogrenci tipinde bir parametre gönderiyoruz önceden string ile integer ile çalışmıştık biz burada bir nesneyi tip olarak tanımlıyoruz.
            {
                Console.WriteLine("Kayıt Edilen Kişi: " + personel.Adi + " " + personel.Soyadi);
            }

            public void Ekleme(Ogrenci ogrenci) // Bir Ekleme methodu ekliyoruz  ve buna Ogrenci tipinde bir parametre gönderiyoruz önceden string ile integer ile çalışmıştık biz burada bir nesneyi tip olarak tanımlıyoruz.
            {
                Console.WriteLine("Kayıt Edilen Kişi: " + ogrenci.Adi + " " + ogrenci.Soyadi);
            }

            //public void Ekleme(IInsan insan) // Bir Ekleme methodu ekliyoruz  ve buna Ogrenci tipinde bir parametre gönderiyoruz önceden string ile integer ile çalışmıştık biz burada bir nesneyi tip olarak tanımlıyoruz.
            //{
            //    Console.WriteLine("Kayıt Edilen Öğrenci: " + insan.Adi + " " + insan.Soyadi+" Sinifi:");
            //}
        }
    }
}
