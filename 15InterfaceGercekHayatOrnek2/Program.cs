using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15InterfaceGercekHayatOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {



            MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
            musteriIslemleri.Ekleme(new SqlServerMusteriDal()); // new lediğimiz zaman bizden bana bir method daha belirt interface yapısına hangisini tanımlayacağımı göndereyim diyor.
            musteriIslemleri.Ekleme(new OracleMusteriDal()); // new lediğimiz zaman bizden bana bir method daha belirt interface yapısına hangisini tanımlayacağımı göndereyim diyor.
             musteriIslemleri.Ekleme(new MysqlMusteriDal());



            IMusteriDal[] musteriDals = new IMusteriDal[3]  //Bir IMusteriDal türünde Array tanımladık  ve 2 elemanlı olacak dedik ilk elemanı sqlServer ikinci elemanı oracle bu işlemi yaptığımızda bu array foreach ile tüm ortamları gezebilir ve bir değişkene atabilirim. bu değişken ile bu classların içinde bulunan tüm methodlara erişip aynı anda farklı işlemler yaptırabilirim.
            {
                new SqlServerMusteriDal(),
                new OracleMusteriDal(),
                new MysqlMusteriDal(), // yeni bir veritabanına daha destek vermek istediğimizde kolayca ekleyebiliriz. ve tüm projemizde bunu uygulayabiliriz.
            };

            foreach (var musteriDal in musteriDals)
            {
                musteriDal.Add(); // musteridal değişkenine tanımlanmış tüm add methodlarına eriştik ve tüm veritabanlarına işlem yaptırmış olduk.
            }

            Console.ReadLine();
        }

     
    }
}
