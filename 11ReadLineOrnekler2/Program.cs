using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ReadLineOrnekler2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2 adet Parametre alacak bir method oluşturulacak. Bu methoda gönderilen değerler toplanarak ekrana yazdırılacak. Gönderilen değerler Konsol uygulamasını kullanan kişiden istenilecek. "Lütfen sayı 1 giriniz" ve "Lütfen sayı 2 giriniz" gibi....


            Console.WriteLine("Lütfen Toplanacak 1. sayıyı giriniz.");
            int sayi1 = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32() <<< Herhangi bir veri tipine ait olan sonucu yada değişkeni integer'a çevirir
           
            Console.WriteLine("Lütfen Toplanacak 2. sayıyı giriniz.");
            int sayi2 = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32() <<< Herhangi bir veri tipine ait olan sonucu yada değişkeni integer'a çevirir

            ToplaVeYaz(sayi1, sayi2);
            Console.ReadLine();

            //SORU : 2 Adet Parametre değer alacak. Parametrelerden bir tanesi "Her gün okunan sayfa sayısı", diğeri ise "Kitabın tolam sayfa sayısı" her gün belirlenen sayfa  sayısı kadar okuyarak belirlenen kitap sayfa sayısını  kaç günde bitirir.

            //1. Konsol surusu Günlük okunan sayfa sayısı

            //2. Konsol surusu Kitabın toplam kaç sayfa

        }

        static void ToplaVeYaz(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}
