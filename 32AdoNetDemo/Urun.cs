using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32AdoNetDemo
{
    public class Urun  // Veritabanından değer alacağımız bir nesne örneği oluşturuyoruz.
    {
        public int Id { get; set; }  // Field oluşturuyoruz
        public string UrunAdi { get; set; } // Field oluşturuyoruz
        public decimal UrunFiyat { get; set; } // Field oluşturuyoruz
        public int StokAdet { get; set; } // Field oluşturuyoruz
    }
}
