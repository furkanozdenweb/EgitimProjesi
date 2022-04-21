using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21LogKayitOrnekClasslar
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            MusteriIslemleri musteriIslemleri= new MusteriIslemleri();
            musteriIslemleri.LogKaydedici = new SqlLogKaydet(); // ILogKayitlari turunde LogKaydedici değişkenini tanımladık.
            musteriIslemleri.Kaydet();
            Console.ReadLine();
        }
    }

    class MusteriIslemleri
    {
        public ILogKayitlari LogKaydedici { get; set; }  //
        public void Kaydet()
        {
            LogKaydedici.logKAydet();
            Console.WriteLine("Müşteri Kaydedildi.");
        }
    }

    class SqlLogKaydet: ILogKayitlari
    {
        public void logKAydet()
        {
            Console.WriteLine("SQL Loglar Kaydedildi.");
        }
    }

    class JsonLogKaydet : ILogKayitlari
    {
        public void logKAydet()
        {
            Console.WriteLine("Dosyaya Loglar Kaydedildi.");
        }
    }

 
    interface ILogKayitlari
    {
         void logKAydet();
    }
}
