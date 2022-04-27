using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26StaticClassveMethodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassimNewlenmez.sayi = 2;


            ClassimNewlenmez.sayi = 7; // Bellekte değişir ve tüm kullanıclar aynı değeri alır. Sunucu belleğinde olduğu için web uygulamalrında biri değişirse tüm kullanıcılarda değişir. Uzak durmamız gereken bir nesne türüdür. Giriş işlemlerini tutup bunları kontrol edebiliris proje üzerinden.

            Islemler.EkranaYazStatic(); //Static newlenmeden direk sınıfın üzerinden tanımlanır.
            Console.WriteLine(ClassimNewlenmez.sayi);
            Console.ReadLine();
        }
    }

    static class ClassimNewlenmez // statik nesne newlenmeden kullanılabilir.
    {
        public static int sayi { get; set; }  //Field tanımlanırken Statik nesnelerde static etiketini eklemeliyiz.
        
    }

     class Islemler // Class static olursa alttaki tüm methodlarda static olmalıdır!
    {
        public void EkranaYaz()
        {
            Console.WriteLine("Merhaba Yazdım!");
        }

        public static void EkranaYazStatic()
        {

            Console.WriteLine("Merhaba Yazdım Static!!");
        }
    }

    static class StatikClassim
    {
        static StatikClassim() // static classsların constructor methodlarıda static olur !!
        {

        }
    }

}
