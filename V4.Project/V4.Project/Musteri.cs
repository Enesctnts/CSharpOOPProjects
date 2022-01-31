using System;
using System.Collections.Generic;
using System.Text;
using static V4.Project.Enumlar;

namespace V4.Project
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public Cinsiyetler Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public UrunSepeti MusterininUrunSepeti { get; set; }

        public void MusteriBilgileriniYazdir()
        {
            Console.WriteLine("Musterinin Bilgileri" + " \nID: " + MusteriId + "\n"  + MusteriAd + " " + MusteriSoyad + "\n");
        }
        public void MusterininSepetiniYazdir()
        {
            DateTime bugun = DateTime.Now.Month;
            if (DogumTarihi == bugun)
            {
                Console.WriteLine("Doğum Gününüz Kutlu Olsun");
                int sayac = 1;
                string cikolata;
                foreach (var item in MusterininUrunSepeti.UrunlerListesi)
                {
                    Console.WriteLine(sayac + ". ürünüz: " + item.UrunAd);
                    sayac++;

                }
                Console.WriteLine("+ bizden cikolata kazandınız.");
                Console.WriteLine(bugun);
            }
            else
            {
                Console.WriteLine(DogumTarihi);
                int sayac = 1;
                foreach (var item in MusterininUrunSepeti.UrunlerListesi)
                {
                    Console.WriteLine(sayac + ". ürünüz: " + item.UrunAd);
                    sayac++;
                }
            }
            
        }


    }
}
