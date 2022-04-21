using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25TemelSınıfınYapıcıBlogunaParametreYollamak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonelManager personelManager = new PersonelManager("Merhaba Dünya!");
            personelManager.Mesaj();
            Console.ReadLine();
        }
    }

    class MirasAlinacakAnaClassMesajimiz
    {
        private string _icerik;
        public MirasAlinacakAnaClassMesajimiz(string icerik) // Yapı denetimi sınıfı constructor
        {
            _icerik = icerik;
        }
        public void Mesaj()
        {
            Console.WriteLine("Merhaba Mesajınız: {0}", _icerik);
        }
    }

    class PersonelManager: MirasAlinacakAnaClassMesajimiz // inherit edip burada miras alırken eğer constructor ile veri istiyorsak burada da tanımlamak zorundayız!!
    {
        public PersonelManager(string icerik):base(icerik)  // Bir constructor methodu da burada tanımlayıp gelen değeri isteyerek ":" sonrası 'base()' diyerek  yine bizim inherit yani miras alıdğımız classsa onu gönderebiliriz. ! Parametreyi base sınıf için aracılık etmiş oluruz

        {

        }
    }
}
