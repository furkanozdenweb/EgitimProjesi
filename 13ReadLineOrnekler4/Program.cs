using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ReadLineOrnekler4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 adet "sayi" parametresi alan ve bu sayıdan başlayarak "0" sıfıra kadar geriye sayan ve ekrana yazdıran bir method oluşturalım.
            //Console.WriteLine("0'a kadar bir eksilerek gidecek sayınızı girin");
            //int KullanicininGirdigiSayiDegeri =Convert.ToInt32(Console.ReadLine());
            //SifiraKadarYaz(KullanicininGirdigiSayiDegeri);

            // 1 adet "sayi" parametresi alan,  Eğer sayı kullanıcıdan istendiğinde yüze eşit ise 100e eşittier büyük ise 100den büyüktür ve yüzden küçük ise bu sayıdan başlayarak "100" e kadar  sayan ve ekrana yazdıran bir method oluşturalım.

            Console.WriteLine("Bir sayı girin");
            int KullanicininGirdigiSayiDegeri2 = Convert.ToInt32(Console.ReadLine());
            Sayi100Islemi(KullanicininGirdigiSayiDegeri2);

            Console.ReadLine();
        }

        static void Sayi100Islemi(int sayi)
        {
            if (sayi == 100)
            {
                Console.WriteLine("Girmiş olduğunuz sayı 100dür.");
            }
            else if (sayi > 100)
            {
                Console.WriteLine("Girmiş olduğunuz sayı 100den büyüktür.");
            }
            else
            {
                while (sayi <= 100)
                {
                    Console.WriteLine(sayi);
                    sayi++;
                }
            }
        }






        static void SifiraKadarYaz(int sayi)
        {
            while (sayi >= 0)
            {
                Console.WriteLine(sayi);
                sayi--;
            }
        }
    }
}
