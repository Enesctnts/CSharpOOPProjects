using System;
using System.Threading;

namespace RentaBike
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici1 = new Kullanici()
            {
                AdSoyad = "Enes Çetintaş",
                Id = 1,
                Telefon = "05458817135"
            };
            Bisiklet bisiklet1 = new Bisiklet()
            {
                Marka = "Bisan"
            };

        

        Kiralama kiralama = new Kiralama();
            kiralama.kullanici = kullanici1;
            kiralama.bisiklet = bisiklet1;
            Console.WriteLine("Ne kadar biniceksin dk?");
            int sure = int.Parse(Console.ReadLine()) * 1000;

            kiralama.Baslat();

            Thread.Sleep(sure);

            kiralama.Bitir();

            

        }
    }
}
