using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrnekV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Events-Depo
            //Soru: Kapasitesi 10 olan bir depoya, urun ekleme ve çıkarma işlemi yapılacaktır. Deponun içinde urun kalmadıgında ve depo
            //doldugunda çalışacak olayların tanımlanması istenmektedir. ayrıca depo içerisnindeki tüm urunlerin listesini veren sınıfı yazınız?


            Depo depo = new Depo(10);

            depo.DepoDolu += Depo_DepoDolu;
            depo.DepoBos += Depo_DepoBos;

            Urun urun = new Urun() { UrunId = 123, UrunAdi = "Kalem", Fiyat = 23 };

            for (int i = 0; i < 13; i++)
            {
                depo.Ekle(urun);

                foreach (Urun u in depo)
                {
                    Console.WriteLine(u);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < 15; j++)
            {
                depo.Cıkar(urun);
            }

        }

        private static void Depo_DepoBos(object sender, EventArgs e)
        {
            Console.WriteLine("Depo BOS");
        }

        private static void Depo_DepoDolu(object sender, EventArgs e)
        {
            Console.WriteLine("Depo DOLU");
        }
    }
}
