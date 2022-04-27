using System;
using System.Collections.Generic;
using System.Data; //  Ado net küütphanesini kullanacak isek biz bu kütüphaneyi using ile projemize eklemeliyiz.
using System.Data.SqlClient;// Ado net küütphanesini kullanacak isek biz bu kütüphaneyi using ile projemize eklemeliyiz.

namespace _32AdoNetDemo
{
    public class UrunDal //Sonu dal ile biten isimlendirmeler kurumsal mimarilerde dal veri tabanı işlemleri yaapacağımızı anlarız ! "tablo adı" ve Data Access Layer - Veri Erişim Katmanı kısaltması "tablo adı+ "Dal"
    {

        SqlConnection _baglan = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial catalog=AlisverisDb;integrated security=true;");
        //@ et işareti koyarsak burada yazdığımız herşeyi string olarak kabul et demektir.
        //server =  bağlanacağımız sunucu bilgisini tutar
        //Initial catalog = Veritabanı Adımızı ister


        public List<Urun> Getir() // Liste tipinde değer döndürecek ve Bu listenin Urun nesnesi tipinde bir getir methodu tanımladık
        {


            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open(); // Veritabanına bağlantı açmak zorundayız bunun içerisine erişim sağlayacak isek.
            }
            SqlCommand komut = new SqlCommand("Select * from Urun", _baglan); // Sql Command kodumuzu istiyor yani veritabanı ile ne işlem yapacağız. bu comutu ve hangi bağlantıya göndereceğimizi tanımlıyoruz.
            SqlDataReader okuyucu= komut.ExecuteReader();// Bu method ile kodumuzu  ExecuteReader Methoduyla tetikliyoruz ve  reader nesnesine komutları çalıştırarak atıyorum.

            List<Urun> urunler = new List<Urun>(); //urunler koleksiyonu oluşturduk.
            
            while (okuyucu.Read()) { // Her okuduğumuz elemanı while ile döndürerek uruns nesneme attım
                Urun urun = new Urun {
                    Id = Convert.ToInt32(okuyucu["Id"]),  // Reader'dak Sütun Adı Id olan değeri ver. İlgili Veri tipine Convert ettik
                    UrunAdi = okuyucu["UrunAdi"].ToString(),// Reader'dak Sütun Adı "UrunAdi" olan değeri ver. İlgili Veri tipine Convert ettik
                    UrunFiyat =Convert.ToDecimal(okuyucu["UrunFiyat"]),// Reader'dak Sütun Adı "UrunFiyat" olan değeri ver. İlgili Veri tipine Convert ettik
                    StokAdet = Convert.ToInt32(okuyucu["StokAdet"])// Reader'dak Sütun Adı "StokAdet" olan değeri ver. İlgili Veri tipine Convert ettik
                };
                urunler.Add(urun); //Gelen her bir datayı ürünler koleksiyonuna ekliyoruz.
            }
            _baglan.Close();
            return urunler; //Ürünler koleksiyonunu geri gönderiyoruz

        }
  
        public void Ekle(Urun urun)
        {
            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open(); // Veritabanına bağlantı açmak zorundayız bunun içerisine erişim sağlayacak isek.
            }

            SqlCommand command = new SqlCommand("insert into Urun (UrunAdi,UrunFiyat,StokAdet) values(@UrunAdi, @UrunFiyat, @StokAdet)", _baglan); // Sql Command kodumuzu istiyor yani veritabanı ile ne işlem yapacağız. bu comutu ve hangi bağlantıya göndereceğimizi tanımlıyoruz.
            command.Parameters.AddWithValue("@UrunAdi", urun.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyat", urun.UrunFiyat);
            command.Parameters.AddWithValue("@StokAdet", urun.StokAdet);
            command.ExecuteNonQuery();//Çalıştırıyoruz. bu aynı zamanda etkilenen kayıt sayısını döndürür.
          
        }


        public void Duzenle(Urun urun)
        {
            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open(); // Veritabanına bağlantı açmak zorundayız bunun içerisine erişim sağlayacak isek.
            }

            SqlCommand command = new SqlCommand("Update Urun set UrunAdi=@UrunAdi ,UrunFiyat=@UrunFiyat,StokAdet= @StokAdet where id=@id", _baglan); // Sql Command kodumuzu istiyor yani veritabanı ile ne işlem yapacağız. bu comutu ve hangi bağlantıya göndereceğimizi tanımlıyoruz.
            command.Parameters.AddWithValue("@id", urun.Id);
            command.Parameters.AddWithValue("@UrunAdi", urun.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyat", urun.UrunFiyat);
            command.Parameters.AddWithValue("@StokAdet", urun.StokAdet);
            command.ExecuteNonQuery();//Çalıştırıyoruz. bu aynı zamanda etkilenen kayıt sayısını döndürür.

        }

        public void Sil(int urunId)
        {
            if (_baglan.State == ConnectionState.Closed)
            {
                _baglan.Open(); // Veritabanına bağlantı açmak zorundayız bunun içerisine erişim sağlayacak isek.
            }

            SqlCommand command = new SqlCommand("delete  from Urun where id=@id", _baglan); // Sql Command kodumuzu istiyor yani veritabanı ile ne işlem yapacağız. bu comutu ve hangi bağlantıya göndereceğimizi tanımlıyoruz.
            command.Parameters.AddWithValue("@id", urunId);
            command.ExecuteNonQuery();//Çalıştırıyoruz. bu aynı zamanda etkilenen kayıt sayısını döndürür.

        }


    }
}
