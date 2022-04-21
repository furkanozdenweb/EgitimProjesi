using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _22PrivateveProtectedTanimlamalar; // Farklı projeden referans olarak alım yapacak isek bu alana projeyi başvuru olarak ekleyip daha sonra using ile çağırmalıyız. 
namespace _22_1PublicErisimBildirgeciCagirmaOrnekProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KursIslemleri kursIslemleri = new KursIslemleri(); //Başvuruya ilgili proje dosyası eklenmesi gerkeli. Daha sonra using kısmında tanımlanması lazım.
        }
    }
}
