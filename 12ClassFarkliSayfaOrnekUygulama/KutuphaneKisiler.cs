using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ClassFarkliSayfaOrnekUygulama
{
    internal class KutuphaneKisiler
    {

    }

    class KutuphaneCalisan: IKisi
    {
       public int id { get; set; }
        public string AdSoyad { get; set; }
        public string Sehir { get; set; }



    }
}
