using SahibindenDemo.Sahibinden;
using System;
using System.Threading;

namespace SahibindenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AltClass nesne = new AltClass();
            nesne.AdSoyad = "Salih Uçan"; //AltClass özelliği
            nesne.KayitTarihi = DateTime.Now; // Ana Class özelliği
            nesne.IlanTarihi = Convert.ToDateTime("2022-01-15");
            nesne.IlanTarihiYaz(); // AnaClass metodu.
            nesne.AdSoyadYaz();  // AltClass metodu
            nesne.BilgiYaz();    // AltClass metodu
            int ilanNO = 1;

            //Thread.Sleep(5000);  // 5 saniye bekliyor.
            AltClass2 nesne2 = new AltClass2();
            nesne2.KayitTarihi = DateTime.Now;
            nesne2.Baslik = "Uygun fiyatlı olta takımı";

            nesne2.IlanTarihi = Convert.ToDateTime("2022-01-15");
            nesne2.IlanTarihiYaz();
            nesne2.BaslikYaz();

            AnaClass anaNesne = new AnaClass();
            anaNesne.IlanTarihi = Convert.ToDateTime("2021-01-15");
            anaNesne.KayitTarihi = Convert.ToDateTime("2021-01-15");
            anaNesne.IlanTarihiYaz();

            EnAltClass enAltNesne =
                new EnAltClass(23, DateTime.Now, "Hakan Şükür", "uzun");

            Kullanici Shakir = new Kullanici();
            Shakir.AdSoyad = "Şakir Demir";
            Shakir.Telefon = "05324445566";
            Console.WriteLine(Shakir.AdSoyad);


            //Test Amaçlı
            Ilan ilan = new Ilan();
            ilan.IlanNo = ilanNO;
            ilan.Fiyat = 100;
            ilan.Baslik = "Şok indirimler";
            ilan.IlanTarihi = DateTime.Now;
            ilan.Satici = Shakir;
            ilan.BilgiYaz();

            Dizustu dzb = new Dizustu();
            dzb.Kategori = Kategori.Dizüstü_Bilgisayar;
            dzb.IlanNo = ilanNO;
            dzb.IlanTarihi = DateTime.Now;
            dzb.Baslik = "Sağlam Dizüstü";
            dzb.Agirlik = 2.3f;
            dzb.Islemci = "AMD Ryzen 7";
            dzb.Fiyat = 10000.0d;
            dzb.Marka = "Lenova";
            dzb.Bellek = "32Gb";
            dzb.HDD = 0;
            dzb.SSD = 1024;
            dzb.EthernetVarMi = true;
            dzb.WifiVarMi = true;
            dzb.EkranBoyutu = "14";
            dzb.Satici = Shakir;
            ilanNO++;
            dzb.BilgiYaz();

            Masaustu msb = new Masaustu();
            msb.Kategori = Kategori.Masaüstü_Bilgisayar;
            msb.IlanNo = ilanNO;
            msb.IlanTarihi = DateTime.Now;
            msb.Baslik = "Sağlam Masaüstü ";
            msb.KasaTipi = KasaTipi.Dikey;
            msb.Islemci = "AMD Ryzen 7";
            msb.Fiyat = 10000.0d;
            msb.Marka = "Hp";
            msb.Bellek = "32Gb";
            msb.HDD = 0;
            msb.SSD = 1024;
            msb.EthernetVarMi = true;
            msb.WifiVarMi = true;
            msb.MonitorVarmi = false;
            msb.Satici = Shakir;

            msb.BilgiYaz();




        }
    }
}
