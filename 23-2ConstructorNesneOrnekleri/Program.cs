using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_2ConstructorNesneOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UrunBilgisi urunBilgisi1 = new UrunBilgisi(2,"Kitap");// Tanımlama kısmında constructor yapı denetimi 
            UrunBilgisi urunBilgisi2 = new UrunBilgisi();
            urunBilgisi2.Id = 2;
            urunBilgisi2.UrunAdi = "Masa";
        }
    }


    class UrunBilgisi  // Kurallara uygun olarak oluşturduğumuz bir nesne classı örneği
    {
        private int _id = 0;
        private string _urunAdi = "Boş";

        public UrunBilgisi() // ctor tab newlediği anda çalışmasını istediğimiz constructor yapı denetimi methodu ile veri gelmeme durumu var ise
        {

        }
        public UrunBilgisi(int id, string urunAdi) // ctor newlediği anda çalışmasını istediğimiz constructor yapı denetimi methodu ile veri gelme durumu var ise.
        {
            _id = id;
            _urunAdi = urunAdi;
        }
        public int Id { get; set; }
        public string UrunAdi { get; set; }
    }
}
