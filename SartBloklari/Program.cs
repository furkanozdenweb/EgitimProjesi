using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SartBloklari
{
    class Program
    {
        static void Main(string[] args)
        {
            // if / else if / else

            int sayimiz = 10;
            if (sayimiz == 10)
            {
                Console.WriteLine("Sayımız 10dur.");
            }
            else if (sayimiz == 20)
            {
                Console.WriteLine("Sayımız 20dir.");
            }
            else
            {
                Console.WriteLine("Sayımız 10 ve 20 değildir.");
            }
            Console.ReadLine();




            //Switch bloklarının kullanımı
            switch (sayimiz)
            {
                case 10:  // Sayimiz 10 olma durumunda
                    Console.WriteLine("Sayımız 10dur.");
                    break;// ilgili swtich şart bloğundan olayı kes yani noktala bu şekilde süslü parantezin dışına çıkar.
                case 20:
                    Console.WriteLine("Sayımız 20dir.");
                    break;
                default://Hiçbir case'e uymuyor sie default olarak yapması gereken işlemi yapar.
                    Console.WriteLine("Sayımız 10 ve 20 değildir.");
                    break;
            }
            Console.ReadLine();


            //Not: Control+K ve Elimizi çekip Control+D Basarsak kodu düzeltir. Belge biçimlendirme yapar.



            /* ##### ÇOKLU ŞART BLOKLARI İLE ÇALIŞMAK. */

            if (sayimiz == 10 || sayimiz == 20) // Veya
            {
                Console.WriteLine("Her iki koşuldan sadece 1 tanesine uysa bile ekrana yazdım.");
            }

            if (sayimiz == 10 && sayimiz == 20) // Ve
            {
                Console.WriteLine("Her iki koşulda doğru olmak zorunda");
            }

            /* ##### Örnek proje yap Bir sayı belirleyelim 0dan büyük 100 den küçükse sayı 0 ile 100 arasındaysa, 100 den büyük ve 200 den küçük ise , 0dan küçük veya 200 den büyük ise sayı 0 ile 200 arasında değl. */




        }
    }
}
