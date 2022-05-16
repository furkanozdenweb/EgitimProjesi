using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35Ornekler
{
    internal class Islemler
    {
        public int Ornek1(int a, int b, string c)
        {
            int s = 0;
            if (c == "Toplama")
            {
                s = a + b;
            }
            else if (c == "Çarpma")
            {
                s = a * b;
            }
            else if (c == "Bölme")
            {
                s = a / b;
            }
            else if (c == "Çıkartma")
            {
                s = a - b;
            }
            else
            {
                s = 0;
            }

            return s;
        }



        public void Ornek2(int a, string b)
        {
            if (a <= 100)
            {
                for(int i = 0; i < a; i++)
                {
                    Console.WriteLine(":) Merhaba "+ b);
                }
            }
            else
            {
                Console.WriteLine("Merhaba");
            }
        }

        // 2 adet integer değer kullanıcı tarafından konsol ekranında giriş yapılacak. 
        // Girilen sayıların toplamları 100den küçük ise toplamları yüzden küçük, yüzden büyük ise toplamları yüzden büyük yazsın. Eğer 100'e eşitse  yüzde eşit yazsın.

        public void Ornek3()
        {
            Console.WriteLine("Lütfen 1. sayı giriniz.");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayı giriniz.");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi1 + sayi2;
            if (sayi1 + sayi2 < 100)
            {
                Console.WriteLine("Toplamları yüzden küçüktür. Toplamı: "+ sonuc);
            }else if (sayi1+sayi2>100)
            {
                Console.WriteLine("Toplamları yüzden büyüktür. Toplamı: {0} ",sonuc);
            }
            else
            {
                Console.WriteLine("Sayıların toplamları 100'e eşittir.");
            }
        }


   
        public void Ornek4(int sayim1, ref int sayim2)
        {
            if(sayim1*sayim1 > sayim2)
            {
                Console.WriteLine("birinci sayının karesi sayi2 den büyüktür.");
            }
            else
            {
                for( int i = 0; i < sayim1; i++)
                {
                    Console.WriteLine("birinci sayının karesi sayi2 den büyük değildir!.");
                }
                sayim2 = 100;
            }
        }


        public void Ornek5()
        {
            Console.WriteLine("Lütfen bir cümle giriniz");

            string deger=Console.ReadLine();
            int kacHarfVar = deger.Length-1;

            if (kacHarfVar > 20)
            {
                for (int i = kacHarfVar; i >=0 ; i--)
                {
                    Console.WriteLine(deger[i]);
                }
            }
            else
            {
                for (int i = 0; i < kacHarfVar; i++)
                {
                    Console.WriteLine(deger[i]);
                }
            }
        }













        // method içerisinde alınacak  2 Adet girilen sayı arasındaki tek sayıları bulan method 
      

        public void Ornek6()
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());


            for (int i = sayi1; i <= sayi2; i++)
            {
                int s = i % 2;
                if (s == 1)
                {
                    Console.WriteLine(i);
                }
                
            }
        }

        // Klavyeden 1 sayı girilmesi istenecek.
        // girilen sayı kadar kişinin sırasıyla ismini cinsiyet (Erkek-Kadın) ve yaşbilgisi girilecek.
        // girilen kişilerin cinsiyetleri erkek ise Askerlik durumları tekrar sorulacak . Yapıldı, Muaf , Tecilli bilgisi istenecek. Tecilli girilmiş ise hangi yıla kadar (YYYY) şu kadar yıl sonra askere gideceksiniz. class ta tutulacak

        public List<Kisiler> islem(int sayi)
        {

            List<Kisiler> kisiler = new List<Kisiler>();
            
            for (int i = 1; i <= sayi; i++)
            {
                string askerlik = "";
                int yil=0;
                Console.Write("Adınızı Giriniz: ");
                string adi = Console.ReadLine();
                Console.Write("Yaşınızı Giriniz: ");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cinsiyet Giriniz: ");
                string cinsiyet = Console.ReadLine();

                if(cinsiyet=="Erkek" && yas > 20)
                {
                    Console.Write("Askerlik Durumu Giriniz: ");
                    askerlik = Console.ReadLine();

                    if(askerlik == "Tecilli")
                    {
                        Console.Write("Hangi yıla kadar Tecilli: ");
                        yil = Convert.ToInt32(Console.ReadLine());
                    }

                }
                
                kisiler.Add(new Kisiler { Id=i,AdSoyad= adi ,Yas=yas,Cinsiyet=cinsiyet,Askerlik=askerlik,Yil=yil});
                
            }

            return kisiler;

        }




    }
}
