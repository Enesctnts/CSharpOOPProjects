using System;
using System.Collections.Generic;
using System.Text;

namespace RentaBike
{
    public class Kiralama
    {
        public int Id { get; set; }
        public Bisiklet bisiklet { get; set; }
        public Kullanici kullanici { get; set; }
        public float Sure { get; set; }
        public float Ucret { get; set; }
        public DateTime BaşlamaZamani { get; set; }
        public DateTime BitisZamani { get; set; }
        public float SaniyeUcreti { get; set; }

        public Kiralama()
        {
            SaniyeUcreti = 0.25f;
        }

        public void Baslat()
        {
            BaşlamaZamani = DateTime.Now;
        }
        public void Bitir()
        {
            BitisZamani = DateTime.Now;
            UcretHesapla();
        }

        public void UcretHesapla()
        {
            TimeSpan zamanFarki = BitisZamani - BaşlamaZamani;
            int farkSaniye = zamanFarki.Hours*3600 + zamanFarki.Minutes*60 + zamanFarki.Seconds;
            Console.WriteLine("Fark: " + farkSaniye);
            Sure = (float)farkSaniye;
            Ucret = Sure * SaniyeUcreti;
            BilgiYaz();
        }

        public void BilgiYaz()
        {
            Console.WriteLine("Sayin " + kullanici.AdSoyad + "\nBaşlama Zamanı: " + BaşlamaZamani + "\nBitiş Zamanı: " + BitisZamani + 
                            "\nToplam Süre: " + Sure + "\nToplam Ödemeniz Gereken Tutar: " + Ucret);
        }
    }
}
