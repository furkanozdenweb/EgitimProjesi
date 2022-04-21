using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _22PrivateveProtectedTanimlamalar;

namespace _22_3PublicOrnekErisimProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Islemler islemler = new Islemler();    
            islemler.Toplama(2, 6);
            Console.ReadLine();
        }
    }
}
