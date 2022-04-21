using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Classlar
{
    class UrunUIslemleri
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
