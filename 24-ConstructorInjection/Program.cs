using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_ConstructorInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UrunBilgisi urunBilgisi = new UrunBilgisi(1, "Kitap");// Tanımlama kısmında constructor yapı denetimi 
            UrunBilgisi urunBilgisi2 = new UrunBilgisi();
            urunBilgisi2.Id = 2;
            urunBilgisi2.UrunAdi = "Masa";
      
            Console.WriteLine("Ürününüzün Id Numarası:{0} , {1}",urunBilgisi2.Id, urunBilgisi2.UrunAdi);


            Console.ReadLine();
        }
    }


    class UrunBilgisi  // Kurallara uygun olarak oluşturduğumuz bir nesne classı örneği
    {
        private int _id;
        private string _urunAdi;

        public UrunBilgisi() //newlediği anda çalışmasını istediğimiz constructor yapı denetimi methodu ile veri gelmeme durumu var ise
        {

        }
        public UrunBilgisi(int id, string urunAdi) //newlediği anda çalışmasını istediğimiz constructor yapı denetimi methodu ile veri gelme durumu var ise.
        {
            _id = id;
            _urunAdi = urunAdi;
        }
        public int Id {
            get { return _id; }
            set { _id = value; }
        }  // Field Oluşturma
        public string UrunAdi {
            get { return " Ürünününüz: "+_urunAdi; }
            set { _urunAdi = value; }
                
          } // Field Oluşturma
    }



}
