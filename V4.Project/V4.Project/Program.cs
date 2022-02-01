using System;
using static V4.Project.Enumlar;

namespace V4.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Urun urun1 = new Urun()
                {
                    UrunAd = "Ekmek",
                    UrunId = 1000,
                    UrunKategorisi= UrunKategorileri.Gıda
                };
                Urun urun2 = new Urun()
                {
                    UrunAd = "Şarj Aleti",
                    UrunId = 1003,
                    UrunKategorisi = UrunKategorileri.Elektronik
                };

                Urun urun3 = new Urun()
                {
                    UrunAd = "Şampuan",
                    UrunId = 1002,
                    UrunKategorisi = UrunKategorileri.Temizlik
                };

                Urun urun4 = new Urun()
                {
                    UrunAd = "Süt",
                    UrunId = 1001,
                    UrunKategorisi = UrunKategorileri.Gıda
                };
                Musteri musteri = new Musteri()
                {
                    MusteriId = 1,
                    Cinsiyet = Cinsiyetler.Erkek,
                    DogumTarihi = new DateTime(1969, 2, 1),
                    MusteriAd = "Veysel",
                    MusteriSoyad = "PERÜ"
                   
                };
                UrunSepeti musterininSepeti = new UrunSepeti()
                {
                    MusteriId = musteri.MusteriId,
                    SepetId = 1
                };
                musterininSepeti.UrunlerListesi.Add(urun1);
                musterininSepeti.UrunlerListesi.Add(urun2);
                musterininSepeti.UrunlerListesi.Add(urun3);
                musterininSepeti.UrunlerListesi.Add(urun4);

                //önce sepeti ve sepete eklenecek ürünleri
                //yukarda aldık,sonra bu sepeti müşteriye atadık.
                
                musteri.MusterininUrunSepeti = musterininSepeti;
                musteri.MusteriBilgileriniYazdir();
                musteri.MusterininSepetiniYazdir();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            Console.ReadLine();
        }
    }
}