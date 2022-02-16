using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
         abstract class Sekil
        {
            public string Renk  { get; set; }
        }
        class Daire:Sekil
        {

        }
        class Silindir:Daire
        {

        }
        sealed class Koni:Silindir
        {

        }
        //class KesikKoni : Koni { } ==> Koniyi sealed tanımladıgımız için koniyi miras veremiyoz

        static class Veritabani
        {
            //public  void Kaydet1() { } // Hatalı Static classların propertyleride static olmalıdır
            public static void Kaydet() { }
        }

        class Asker
        {
            static int sayac = 0;
            public Asker()
            {
                sayac++;
                Console.WriteLine(sayac);
            }
            
            ~Asker()
            {
                sayac--;
                Console.WriteLine(sayac);
            }

        }
        static void Main(string[] args)
        {
            //Abstract oldugu içi olmaz sadece başka yerden biras alırsa olur.
            //Sekil sekil = new Sekil();

            Asker asker1 = new Asker();
            Asker asker2 = new Asker();
            Asker asker3 = new Asker();

        }
    }
}
