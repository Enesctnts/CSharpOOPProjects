using System;

namespace HairDesingProject
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


            kullanici1.kuafor.SakalTrasiYap();
            kullanici1.kuafor.SacYikamaYap();

            kullanici1.kuafor.BilgiYaz();



        }
    }
}
