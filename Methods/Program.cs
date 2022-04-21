using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Methodu projemizde çağırmak. */ 
            //EklemeYap();
            //Console.ReadLine();



            /* Parametreli method kullanımı örneği ToplamaYap Methoduna 2 adet parametre göndermişiz. */
            //int toplam = ToplamaYap(23, 25); 
            //Console.WriteLine(toplam);
            //Console.ReadLine();


            /* Örnek 1 Standart Method, Ekran Görüntüsü Nedir? */
            //int number1 = 40;
            //int number2 = 100;
            //int sonuc = OrnekTopla1(number1, number2);
            //Console.WriteLine(sonuc);
            //Console.WriteLine(number1);
            //Console.ReadLine();



            /* Örnek 2 - Ref Keyword Method */
            //int number1 = 40;
            //int number2 = 100;
            //int sonuc = OrnekTopla2(ref number1, number2);

            //Console.WriteLine(sonuc);
            //Console.WriteLine(number1);
            //Console.ReadLine();

            /* Örnek 3 - OutKeyword Method */
            //    int number1 ;
            //    int number2 = 100;
            //    int sonuc = OrnekTopla3(out number1, number2);

            //    Console.WriteLine(sonuc);
            //    Console.WriteLine(number1);
            //    Console.ReadLine();



            /* Örnek 4 Aşağıda Method Tanımlanması. */



            /* Örnek 5  -  Params Keyword */
            Console.WriteLine(ToplamaIslemiToplu(1, 2, 3, 4, 5, 6, 7, 8));
            Console.ReadLine();

        }


        /* Method  void olarak tanımlanırsa veri döndürmeyeceği anlamına geliyor. */
        static void EklemeYap() 
        {
            Console.WriteLine("Eklendi");
        }

        /* Method int tipinde dönüş yapacağını belirtiyorum. ve 2 adet parametre ile çalışacağımı tanımlamışım. */
        static int ToplamaYap(int sayi1, int sayi2)  
        {
            var sonuc = sayi1 + sayi2;
            return sonuc;  //Veriyi geri döndürür.
        }


        /* Örnek 1 Standart Method */
        static int OrnekTopla1(int number1, int number2)
        {
            number1 = 50;
            int sonuc = number1 + number2;
            return sonuc;
        }
        
       
        /* Örnek 2 - Ref Keyword Method */
        static int OrnekTopla2(ref int number1, int number2)
        {
            number1 = 50;
            int sonuc = number1 + number2;
            return sonuc;
        }



        /* Örnek 3 - OutKeyword Method */
        static int OrnekTopla3(out int number1, int number2)
        {
            number1 = 60;
            int sonuc = number1 + number2;
            return sonuc;
        }

        /* Örnek 4  - Method Overloading */
        static int OrnekTopla3(out int number1, int number2, int number3)
        {
            number1 = 60;
            int sonuc = number1 + number2 + number3;
            return sonuc;
        }

        /* Örnek 5  -  Params Keyword */
        static int ToplamaIslemiToplu(params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}

