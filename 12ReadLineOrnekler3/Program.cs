using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ReadLineOrnekler3
{
    class Program
    {
        static void Main(string[] args)
        {

            //SORU : 2 Adet Parametre değer alacak. Parametrelerden bir tanesi "Her gün okunan sayfa sayısı", diğeri ise "Kitabın tolam sayfa sayısı" her gün belirlenen sayfa  sayısı kadar okuyarak belirlenen kitap sayfa sayısını  kaç günde bitirir.

            //1. Konsol surusu Günlük okunan sayfa sayısı

            //2. Konsol surusu Kitabın toplam kaç sayfa

            Console.WriteLine("Günlük okuduğunuz sayfa sayısını giriniz:");
            int okunanSayfa = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32() <<< Herhangi bir veri tipine ait olan sonucu yada değişkeni integer'a çevirir

            Console.WriteLine("Kitabınızın toplam sayfa sayısını giriniz:");
            int toplamSayfa = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32() <<< Herhangi bir veri tipine ait olan sonucu yada değişkeni integer'a çevirir

            KitapKacGundeBiter(okunanSayfa, toplamSayfa);

            Console.ReadLine();
        }

        static void KitapKacGundeBiter(int GunlukOkumaSayisi,int KitapToplamSayfaSayisi)
        {
            int gun = 0;
            int toplamOkunanSayfaSayisi = 0;
            while(toplamOkunanSayfaSayisi < KitapToplamSayfaSayisi)
            {
                gun++;
                toplamOkunanSayfaSayisi = toplamOkunanSayfaSayisi + GunlukOkumaSayisi;
            }
            Console.WriteLine(gun + ". gün okuduğunuz "+ KitapToplamSayfaSayisi+" sayfalık kitabınız biter.");
           
        }
    }
}
