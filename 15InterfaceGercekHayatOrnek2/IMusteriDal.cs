using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15InterfaceGercekHayatOrnek2
{

    class MusteriIslemleri
    {
        public void Ekleme(IMusteriDal musteriDal)  //Add Methodunu yapacağım fakat parametre olarak "IMuteriDAl" olarak veriyorum. Ne sQL nede oracle mevcut methodu kullandığmızda bize hangi interfaceyi kullanacağını soracak

        {
            musteriDal.Add();

        }
    }
    interface IMusteriDal  // İnterface ile başladığı için Büyük "I" ile başlıyor ve "Dal" ile bitiyor "data access Layer" yani veri tabanı işlemlerini tutacağımız sınıflar
    {

        void Add(); // Ortak olara kullanılacak methodlar
        void Update(); // Ortak olara kullanılacak methodlar
        void Delete(); // Ortak olara kullanılacak methodlar
    }

    class SqlServerMusteriDal : IMusteriDal  // İmplemente Etmek için solda bulunan alana tıklayarak ara birimi uygula diyerek interfacemizdeki fonksiyonları otomatik olarak edebilirsiniz.
    { //    

        public string BaglantiKodu { get; set; }
        public void Add()
        {
            Console.WriteLine("SQl Veritabanına Ekleme İşlemleri bu alanda yapılıyor.");
        }

        public void Delete()
        {
            Console.WriteLine("SQl Veritabanına Silme İşlemleri bu alanda yapılıyor.");
        }

        public void Update()
        {
            Console.WriteLine("SQl Veritabanına Güncelleme İşlemleri bu alanda yapılıyor.");
        }

    }

    class OracleMusteriDal : IMusteriDal  // İmplemente Etmek için solda bulunan alana tıklayarak ara birimi uygula diyerek interfacemizdeki fonksiyonları otomatik olarak edebilirsiniz.
    { //    
        public void Add()
        {
            Console.WriteLine("Oracle Veritabanına Ekleme İşlemleri bu alanda yapılıyor.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Veritabanına Silme İşlemleri bu alanda yapılıyor.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Veritabanına Güncelleme İşlemleri bu alanda yapılıyor.");
        }
    }



    class MysqlMusteriDal : IMusteriDal  // İmplemente Etmek için solda bulunan alana tıklayarak ara birimi uygula diyerek interfacemizdeki fonksiyonları otomatik olarak edebilirsiniz.
    { //    
        public void Add()
        {
            Console.WriteLine("Mysql Veritabanına Ekleme İşlemleri bu alanda yapılıyor.");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql Veritabanına Silme İşlemleri bu alanda yapılıyor.");
        }

        public void Update()
        {
            Console.WriteLine("Mysql Veritabanına Güncelleme İşlemleri bu alanda yapılıyor.");
        }
    }


}
