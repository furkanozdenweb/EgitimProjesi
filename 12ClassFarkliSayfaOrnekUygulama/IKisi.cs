using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ClassFarkliSayfaOrnekUygulama
{
    internal interface IKisi
    {
         int id { get; set; }
         string AdSoyad { get; set; }
         string Sehir { get; set; }
    }
}
