using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22PrivateveProtectedTanimlamalar
{
    internal class KursIslemleri
    {
        public void Ekleme()
        {
            Kurs kurs = new Kurs(); //namespace proje içerisinde tanımlanmış olan internal 
            Console.WriteLine("Ekleme işlemi yapıldı.");
        }
    }

    public class KursIslemleri2
    {
        public void Ekleme()
        {
            KursIslemleri kurs = new KursIslemleri(); //namespace proje içerisinde tanımlanmış olan internal 
            Console.WriteLine("Ekleme işlemi yapıldı.");
        }
    }

    public class Islemler
    {
        public void Toplama(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
            Console.ReadLine();
        }
    }
}
