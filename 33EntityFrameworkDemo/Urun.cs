using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _33EntityFrameworkDemo
{
    public class Urun
    {
        public int Id { get; set; }  // Field oluşturuyoruz
        public string UrunAdi { get; set; } // Field oluşturuyoruz
        public decimal UrunFiyat { get; set; } // Field oluşturuyoruz
        public int StokAdet { get; set; } // Field oluşturuyoruz
    }
}
