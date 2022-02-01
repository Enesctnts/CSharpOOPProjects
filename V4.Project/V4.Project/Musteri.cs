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
        public DateTime DogumTarihi { get; set; }
        public Cinsiyetler Cinsiyet { get; set; }
        public UrunSepeti MusterininUrunSepeti { get; set; }

        public void MusteriBilgileriniYazdir()
        {
            Console.WriteLine("Musterinin Bilgileri" + " \n\nID: " + MusteriId + "\n"  + MusteriAd + " " + MusteriSoyad + "\n");
        }
        public void MusterininSepetiniYazdir()
        {
            DateTime bugun = DateTime.Today;
            if (DogumTarihi.Day == bugun.Day && DogumTarihi.Month == bugun.Month)
            {
                
                int sayac = 1;
                Urun urun5 = new Urun()
                {
                    UrunAd = ("Çikolata").ToUpper(),
                    UrunId = 1004,
                    UrunKategorisi = UrunKategorileri.Gıda
                };

                MusterininUrunSepeti.UrunlerListesi.Add(urun5);
                Console.WriteLine("Doğum Gününüz Kutlu Olsun " + MusteriAd + " Bey Bizden 1 adet " + urun5.UrunAd + " kazandınız.\n");
                foreach (var item in MusterininUrunSepeti.UrunlerListesi)
                {
                    if (item.UrunAd == ("Çikolata").ToUpper())
                    {
                        Console.WriteLine("Hediye ürün: " + item.UrunAd.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine(sayac + ". ürün: " + item.UrunAd.ToUpper());
                    }
                    
                    sayac++;

                }
                
                
            }
            else
            {
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