using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Inheritance_Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Samet";
            musteri.Soyad = "Erdem";
            musteri.Sehir = "Tekirdağ";

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Id = 2;
            ogrenci.Ad = "Özge";
            ogrenci.Soyad = "Erdem";
            ogrenci.Departman = "Yazılım Mühendisliği";

            Kisi[] kisiler = new Kisi[3]
            {
                new Ogrenci{ Id=1,Ad="Samet"},
                new Musteri{ Id=1,Ad="Özge"},
                new Kisi{ Id=1,Ad="Ege"}  // İnterfacelerde tek başına bir anlam ifade etmiyorken inheritance olarak müras alınan classlar tek başınada kullanılabilir.
            }; 

            foreach(var k in kisiler)
            {
               Console.WriteLine(k.Ad);
            }

            Console.ReadLine();
        }
    }

    class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
 
    }

    class Kisi2
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }

    class Musteri : Kisi //, Kisi2  // Miras olarak kişi classımızı tip olarak alacağımızı belirttik , Babası olarak aklımızda kalabilir 2. bir baba tanımlanamaz.
    {
        public string Sehir { get; set; }
    }

    class Ogrenci : Kisi
    {
        public string Departman { get; set; }
    }
}
