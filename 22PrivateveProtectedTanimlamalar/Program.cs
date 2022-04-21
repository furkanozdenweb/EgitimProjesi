using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22PrivateveProtectedTanimlamalar
{
    public class BaskaProjedenErisim
    {
        public void Merhabade()
        {
            Console.WriteLine("Merhaba");
            Console.ReadLine();
        }
    }



     class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan();
            calisan.adi = "Samet";

            KursIslemleri kursIslemleri = new KursIslemleri();
            kursIslemleri.Ekleme();
        }


    }


    class Ogretmen : Calisan  // İnherit ettik yani miras aldık.
    {
        
        public void Kaydet()
        {
            adi = "Cengiz";
            sehir = "İstanbul";
        }
    }



    class Calisan
    {

        private int id; //private default olarak tanımlanır. tanımlandığı blok içerisinde geçerlidir. new olarak referans çekilse bile kullanılamaz.
        public  string  adi; //public tanımlama Bildirgeçleri Ogretmen classını refereans alan heryerden erişilebilir.
        string soyadi;
        private int okulNo { get; set; } //Field Oluşturma
        protected string sehir { get; set; } // Private olarak tanımlanan erişim bildirgeçleri private ile aynı özelliği gösterirler ancak Miras alınması durumunda miras alınan blok tarafından da erişilebilirler.
        public void KaydetmeIslemi()
        {
            adi = "Samet";
            id = 2;
            okulNo = 12;
        }   
        
        public void SilmeIslemi()
        {
            soyadi = "Samet";
        }
    }

    class Ogrenci:Calisan
    {
        public void Kaydet()
        {
            Calisan calisan = new Calisan();
            //calisan.id = 0;
            calisan.adi = "Ahmet";
           // calisan.okulNo=23;

            sehir = "Tekirdağ";// Protected olarak tanımlanan değer privateın bütün özelliklerini karşılar  sadece tanımlandığı blok içerisinde kullanılır.
        }
    }

   

    internal class Kurs // Clasları oluştururken default olarak internal değişim bildirgecini alır.
    {
        public string kursAdi { get; set; }
    }


}
