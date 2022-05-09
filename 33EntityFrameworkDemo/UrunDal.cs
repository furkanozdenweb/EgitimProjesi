using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;

namespace _33EntityFrameworkDemo
{
    internal class UrunDal
    {

        public List<Urun> Getir() // Liste tipinde değer döndürecek ve Bu listenin Urun nesnesi tipinde bir getir methodu tanımladık
        {
            using (AlisverisDbContext alisverisDbContext=new AlisverisDbContext()) //using işlemi içerisinde çalıştığı kod bloğu tamamlandıktan sonra bellekten ilgili nesneleri siler. 
            {
                return alisverisDbContext.Uruns.ToList();  // Listelemek :)

            }
        }





        public List<Urun> IsmeGoreGetir(string key) // VERİTABANI ÜZERİNDE ARAMA YAPMAK! Liste tipinde değer döndürecek ve Bu listenin Urun nesnesi tipinde bir getir methodu tanımladık 
        {
            using (AlisverisDbContext alisverisDbContext = new AlisverisDbContext()) //using işlemi içerisinde çalıştığı kod bloğu tamamlandıktan sonra bellekten ilgili nesneleri siler. 
            {
                return alisverisDbContext.Uruns.Where(p=>p.UrunAdi.Contains(key)).ToList();  // Direk veritabanı üzerinden sorgulama yaptık. Çok fazla datamız var ise sadece ihtiyacımız olan datalar gelir. Böylece bellekproblemi yaşamayız genellikle bu şekilde veritabanı üzerinden çalışırız.
            }
        }



       // Eğer fiyat1.text boş değilse ve fiyat2.text boş değilse 
       // Eğer fiyat1.TExt boş değilse ve fiyat2.text boş ise

        public List<Urun> FiyataGoreGetir(decimal Fiyat) // VERİTABANI ÜZERİNDE ARAMA YAPMAK! Liste tipinde değer döndürecek ve Bu listenin Urun nesnesi tipinde bir getir methodu tanımladık 
        {
            using (AlisverisDbContext alisverisDbContext = new AlisverisDbContext()) //using işlemi içerisinde çalıştığı kod bloğu tamamlandıktan sonra bellekten ilgili nesneleri siler. 
            {
                return alisverisDbContext.Uruns.Where(p => p.UrunFiyat==Fiyat).ToList();  // Direk veritabanı üzerinden sorgulama yaptık. Çok fazla datamız var ise sadece ihtiyacımız olan datalar gelir. Böylece bellekproblemi yaşamayız genellikle bu şekilde veritabanı üzerinden çalışırız.
            }
        }


        public List<Urun> FiyataGoreGetir(decimal Fiyat1,decimal Fiyat2) // VERİTABANI ÜZERİNDE ARAMA YAPMAK! Liste tipinde değer döndürecek ve Bu listenin Urun nesnesi tipinde bir getir methodu tanımladık 
        {
            using (AlisverisDbContext alisverisDbContext = new AlisverisDbContext()) //using işlemi içerisinde çalıştığı kod bloğu tamamlandıktan sonra bellekten ilgili nesneleri siler. 
            {
                return alisverisDbContext.Uruns.Where(p => p.UrunFiyat >= Fiyat1 && p.UrunFiyat<=Fiyat2).ToList();  // Direk veritabanı üzerinden sorgulama yaptık. Çok fazla datamız var ise sadece ihtiyacımız olan datalar gelir. Böylece bellekproblemi yaşamayız genellikle bu şekilde veritabanı üzerinden çalışırız.
            }
        }



        public Urun IdGoreGetir(int Id) // Urun tipinde tek bir değer getir.
        {
            using (AlisverisDbContext alisverisDbContext = new AlisverisDbContext()) //using işlemi içerisinde çalıştığı kod bloğu tamamlandıktan sonra bellekten ilgili nesneleri siler. 
            {
              return alisverisDbContext.Uruns.FirstOrDefault(p => p.Id == Id);  // Data bulamaz ise null data bulur ise ilk bulduğu datayı döndürür
                //  return alisverisDbContext.Uruns.SingleOrDefault(p => p.Id == Id);  // Data bulamaz ise null data bulur ise datanın kendisini döndürür birden fazla data bulur ise hata verir :) Id ile çekeceğimiz değerlerde bunu kullanırız.
            }
        }







        public void Ekle(Urun urun)
        {
            using (AlisverisDbContext alisverisDbContext = new AlisverisDbContext())
            {
                alisverisDbContext.Uruns.Add(urun);  //Eklemek
                alisverisDbContext.SaveChanges();  //Yapılan değişiklikleri kaydetmek
            }
        }


        public void Duzenle(Urun urun)
        {
            using (AlisverisDbContext alisverisDbContext = new AlisverisDbContext())
            {
                var icerik = alisverisDbContext.Entry(urun);  // gönderilen urunun  örneğini oluşturuyoruz
                icerik.State = EntityState.Modified; //Güncelleme işlemini yaptırıyoruz.
                alisverisDbContext.SaveChanges();//Yapılan değişiklikleri kaydetmek
            }
        }



        public void Sil(Urun urun)
        {
            using (AlisverisDbContext alisverisDbContext = new AlisverisDbContext())
            {
                var icerik = alisverisDbContext.Entry(urun); // gönderilen urunun  örneğini oluşturuyoruz
                icerik.State = EntityState.Deleted; //Silme işlemini yaptırıyoruz.
                alisverisDbContext.SaveChanges();//Yapılan değişiklikleri kaydetmek
            }
        }


    }
}
