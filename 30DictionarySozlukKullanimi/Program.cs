using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DictionarySozlukKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dictionary = Okunuşu:  Dikşınary = TR:  Sözlük = "Bir sözlükte olduğu gibi anahtar kelime vasıtası ile onun değerine ulaşmayı hedeflediğimiz yapılardır."

            Dictionary<string, string> sozcuk = new Dictionary<string, string>();  // Bir sözlük gibi düşünebiliriz kelime tipi string olarak gelen değerin karşılığı string tiplerinde olduğunu belirtiyoruz. Anahtar ve değerini string olarak belirleyip bir dictionary nesnesi oluşturduk.

            sozcuk.Add("Kitap", "Book");
            sozcuk.Add("Tablo", "Tablo");
            sozcuk.Add("Bilgisayar", "Computer");
            sozcuk.Add("Pencere", "Window");

            Console.WriteLine(sozcuk["Bilgisayar"]); // Anahtarı vererek karşılığında ne değer olduğunu ekrana yazdırabiliyoruz. Değerin kendisin yazdırırsak anahtara ulaşamayız !
                                                     //Console.WriteLine(dictionary["Glass"]); // Bardak değeri bizim dikşınarymizde olmadığı için hata verir.
            Console.WriteLine("------------------------------");

            foreach (var c in sozcuk) // sozcuk dikşınaryisinin tüm elemanlarını foreach ile alıyoruz. ekrana yazdırıyoruz.
            {
                Console.WriteLine(c.Value);
            }
            Console.WriteLine("------------------------------");
            int elemanSayisi=sozcuk.Count(); //dikşınaryde bir koleksiyon olduğu için koleksiyon ait tüm methodlar ve  özellikleri taşır.
            Console.WriteLine(elemanSayisi);

            Console.WriteLine("------------------------------");
            /* dictionary de özel olan methodlar */

            bool DegerVarmi=sozcuk.ContainsKey("Araba"); // Eğer Key değeri var ise true yok ise false gönderir. 
            Console.WriteLine(DegerVarmi);
            bool DegerVarmi2 = sozcuk.ContainsValue("Car"); // Eğer value değeri var ise true yok ise false gönderir. 
            Console.WriteLine(DegerVarmi2);
            Console.WriteLine("------------------------------");


            Console.ReadLine();


        }
    }
}
