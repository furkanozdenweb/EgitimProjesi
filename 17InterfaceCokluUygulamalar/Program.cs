using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17InterfaceCokluUygulamalar
{
    internal class Program  // Internal Class'lar sadece tanımlandıkları katmanlardan erişim sağlanması özelliğine sahiptirler. Tanımlı oldukları katmanların dışından hiçbir şekilde erişilemezler.
    {
        static void Main(string[] args)
        {
            ICalisan[] calisanlar = new ICalisan[3] // Personeller için, yöneticiler için ve robotlar için çalışma methodunu tuttuk. Foreach ile calisanları gezdiğimde çalış emri verebilirim. Foreach ile 
            {
                new Pesoneller(),
                new Yoneticiler(),
                new Robotlar()
            };

            foreach(var calisan in calisanlar) // Çalışma işlemini tüm çalışanlara uyguladık

            {
                calisan.Calis();
            }

            IYemekYe[] yemekler = new IYemekYe[2]
            {
                new Yoneticiler(),
                new Pesoneller() 
            };

            foreach(var yemek in yemekler)
            {
                yemek.Ye();
            }

            Console.ReadLine();
        }

        
    }

    interface ICalisan //interfaceler tasarlanırken ihtiyaca uygun tasarlanması gerekli.
    {
        void Calis();
     
    }

    interface IYemekYe
    {
        void Ye();
    }

    interface IMaasAl
    {
        void MaasAl();
    }

    class Yoneticiler : IYemekYe, IMaasAl, ICalisan
    {
        public void Calis()
        {
            Console.WriteLine("Çalış");
        }

        public void MaasAl()
        {
            Console.WriteLine("Maaş Al");
        }

        public void Ye()
        {
            Console.WriteLine("Yemek Ye");
        }
    }

    class Pesoneller : IYemekYe, IMaasAl, ICalisan
    {
        public void Calis()
        {
            Console.WriteLine("Çalış");
        }

        public void MaasAl()
        {
            Console.WriteLine("Maaş Al");
        }

        public void Ye()
        {
            Console.WriteLine("Yemek Ye");
        }
    }

    class Robotlar :  ICalisan
    {
        public void Calis()
        {
            Console.WriteLine("Çalış");
        }

      
    }

    //class Yoneticiler : ICalisan
    //{
    //    public void Calis()
    //    {

    //    }

    //    public void MaasAl()
    //    {

    //    }

    //    public void YemekYe()
    //    {

    //    }
    //}

    //class Personel : ICalisan
    //{
    //    public void Calis()
    //    {

    //    }

    //    public void MaasAl()
    //    {

    //    }

    //    public void YemekYe()
    //    {

    //    }
    //}


    //class Robot : ICalisan
    //{
    //    public void Calis()
    //    {

    //    }

    //    public void MaasAl()
    //    {

    //    }

    //    public void YemekYe()
    //    {

    //    }
    //}

}
