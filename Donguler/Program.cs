using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek 1 For Loop 
            // ForLoopOrnek();

            // Örnek 2 While Loop
            //WhileLoopOrnek();

            // Örnek 3 Do While Loop
            //DoWhileLoopOrnek();

            // Foreach Örnek - Dizi temelli dataların dolaşımı için kullanılır.
            // ForeachOrnek();
        }

        private static void ForeachOrnek()
        {
            string[] ogrenciler = new string[3] { "Samet", "Özge", "Ege" };
            foreach (var ogrenci in ogrenciler) // Üzerinde Array tipinde olan dolaşılabilir nesnelerde kullanırız.
            {
                Console.WriteLine(ogrenci);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void DoWhileLoopOrnek()
        {
            int sayimiz = 100;
            do
            {
                Console.WriteLine(sayimiz);
                sayimiz--;
            } while (sayimiz >= 0);
            Console.WriteLine("Sayınız bu {0}", sayimiz);
            Console.ReadLine();
        }


        private static void WhileLoopOrnek()
        {
            int adet = 100;
            while (adet >= 0)
            {
                Console.WriteLine(adet);
                adet--;
            }
            Console.WriteLine("Sayınız bu {0}", adet);
            Console.ReadLine();
        }


        private static void ForLoopOrnek()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Döngü Durdu");
            Console.ReadLine();
        }
    }
}
