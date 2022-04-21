using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //String İşlemleri
            //GirisStringOrnek();
            string cumle = "Merhaba Dünya! Burası benim web sitem.";


            //var sonuc = cumle.Length; // Karakter sayısını alabiliriz.
            //Console.WriteLine(sonuc);


            //var sonuc2 = cumle.Clone();//cumle değişkenini clonlayarak içeriğini sonuc2 ye de atamış oluruz.
            ////cumle = "Merhaba Samet";
            //Console.WriteLine(sonuc2);


            //bool sonuc3 = cumle.EndsWith("ğ"); // Bu cümle "ğ" ile bitiyor mu? bitiyor ise true bitmiyor ise false değerini gönderir.
            //bool sonuc4 = cumle.StartsWith("ğ"); // Bu cümle "ğ" ile başlıyor mu? başlıyor ise true bitmiyor ise false değerini gönderir.
            //Console.WriteLine(sonuc3);    
            //Console.WriteLine(sonuc4);


            //var sonuc5 = cumle.IndexOf("Dünya"); //Bir stringte belli bir karakteri yada bir ifadeyi aratmak için kullanırız. Kaçıncı karakterden başlıyor ise o karakterin endex değerini verir.Bulduğu ilk veriyi alır.Aramaya baştan başlar.
            //Console.WriteLine(sonuc5);


            //var sonuc6 = cumle.IndexOf(" "); //Bir stringte belli bir karakteri yada bir ifadeyi aratmak için kullanırız. Kaçıncı karakterden başlıyor ise o karakterin endex değerini verir. Bulduğu ilk veriyi alır. Aramaya baştan başlar.
            //Console.WriteLine(sonuc6);


            //var sonuc7 = cumle.LastIndexOf(" "); //Bir stringte belli bir karakteri yada bir ifadeyi aratmak için kullanırız. Kaçıncı karakterden başlıyor ise o karakterin endex değerini verir. Bulduğu ilk veriyi alır. Aramaya sondan başlar!
            //Console.WriteLine(sonuc7);


            //var sonuc8 = cumle.Insert(0,"Hoşgeldin, "); // "İnsert ile bir string değişkenine kaçıncı index değerinden sonra istediğimiz metni eklememizi sağlar.
            //Console.WriteLine(sonuc8);


            //var sonuc9 = cumle.Substring(8); // "Substring belirlenen bir karakterden itibaren , ikinci bir karakter belirlenmiş ise o karaktere  sayısı kadar al.
            //Console.WriteLine(sonuc9);


            //var sonuc10 = cumle.Substring(8,5); // "Substring belirlenen bir karakterden itibaren , ikinci bir karakter belirlenmiş ise o karaktere  sayısı kadar al.
            //Console.WriteLine(sonuc10);


            //var sonuc11 = cumle.ToLower(); // "ToLower Belirtilen bütün karakterleri küçük karaktere çevirir.
            //Console.WriteLine(sonuc11);


            //var sonuc12 = cumle.ToUpper(); // "ToLower Belirtilen bütün karakterleri büyük karaktere çevirir.
            //Console.WriteLine(sonuc12);



            //var sonuc13 = cumle.Replace(" ","-"); // " Bütün metnin içindeki boşlukları " ", tire işaretine dönüştürür "-"
            //Console.WriteLine(sonuc13);


            //var sonuc14 = cumle.Remove(7); // " Metnin 7 index değerinden itibaren olan kısmı uçur, sil!
            //Console.WriteLine(sonuc14);


            //var sonuc15 = cumle.Remove(7,6); // " Metnin 7 index değerinden itibaren olan 6 karakteri kısmı uçur, sil!
            //Console.WriteLine(sonuc15);

            Console.ReadLine();

        }

        private static void GirisStringOrnek()
        {
            string sehirAdi = "Tekirdağ";
            Console.WriteLine(sehirAdi[0]);

            foreach (var item in sehirAdi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
