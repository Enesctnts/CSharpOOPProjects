using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari
{
    class Program
    {
        static void Main(string[] args)
        {
            //DI Uygulanmalı..
            KitapBLL bll = new KitapBLL();

            //bll.KitapEkle(new Kitap()
            //{
            //    KitapAdi = "Canakkale Sehitlerine",
            //    KategoriID = 1,
            //    YazarID = 1
            //});
            Console.WriteLine("KitID KitAdi KatID YazID\n");
            foreach (var item in bll.KitapListe())
            {
                Console.WriteLine(item.KitapID + "  " + item.KitapAdi + "  " + item.KategoriID + "  " + item.YazarID);
            }

            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine("YazarID\tKitapAdi\n");
            foreach (var yazar in bll.KitapListeYazar(1))
            {
                Console.WriteLine(yazar.YazarID + "       " + yazar.KitapAdi);
            }

            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine("KategoriID  KitapAdi\n");
            foreach (var kitap in bll.KitapListeKategori(2))
            {
                Console.WriteLine(kitap.KategoriID + "          " + kitap.KitapAdi);
            }


        }
    }
}
