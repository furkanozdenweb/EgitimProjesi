using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34GenericSiniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }



    //interface IUrun
    //{
    //    List<Urun> Getir();
    //    Urun IdGoreGetir(int id);
    //    void Ekleme(Urun urun);
    //    void Guncelle(Urun urun);
    //    void Sil(Urun urun);
    //}



    //interface IMusteri
    //{
    //    List<Musteri> Getir();
    //    Musteri IdGoreGetir(int id);
    //    void Ekleme(Musteri urun);
    //    void Guncelle(Musteri urun);
    //    void Sil(Musteri urun);
    //}


    class Urun
    {
        public int Id { get; set; }
        public int UrunAdi { get; set; }
    }

  


    interface IDepo<T>  // Çalışacağımız bir tip istediğimiz bir interface ! Böylece bizi tekrar tekrar tanımlama derdinden kurtardı.
    {
        List<T> Getir();
        T IdGoreGetir(int id);
        void Ekleme(T urun);
        void Guncelle(T urun);
        void Sil(T urun);
    }



    class Musteri
    {
        public int Id { get; set; }
        public string MusteriAdi { get; set; }
    }

    interface IMusteri: IDepo<Musteri> //Bu şekilde bunu oluşturmamızın nedeni Müşteri için ekstra bir method daha ekleyebilmeliyiz. Böylece bizi tekrar tekrar tanımlama derdinden kurtardı.
    {
        Musteri SehirGetir();
    }




    interface IUrun : IDepo<Urun>// Bu şekilde bunu oluşturmamızın nedeni Müşteri için ekstra bir method daha ekleyebilmeliyiz. Böylece bizi tekrar tekrar tanımlama derdinden kurtardı.
    {

    }





    // class UrunDal : IUrun


    // class musteriDal : IMusteri






    /* Bu alandan itibaren Generic Kısıtlama işlemleri bulunuyor. */


    interface IRepository<T> where T : class, new() //  T bir classtır yani double yada int tipinde değer gönderilemez diyoruz ! , new() diyorsak newlenebilir referans tip istiyoruz böylece string değil sadece classları kabul eder !
    {
        List<T> Getir();
        T IdGoreGetir(int id);
        void Ekleme(T urun);
        void Guncelle(T urun);
        void Sil(T urun);
    }


    interface ReferansTip<T> where T : struct // Referans tip gelebileceğini belirtir  int double gibi.. :)
    {
        List<T> Getir();
        T IdGoreGetir(int id);
        void Ekleme(T urun);
        void Guncelle(T urun);
        void Sil(T urun);
    }
  




}
