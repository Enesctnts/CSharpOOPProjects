using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerslerGenel
{

    class Asker
    {
        public int SicilNo { get; set; }
        public string Vazife { get; set; }
        protected void islem() // sadece tanımlı oldugu class ta ve ondan türeyen classlarda gözükür.
        {

        }
    }

    class Er : Asker
    {

    }


    class Daire
    {
        public double r { get; set; }
        public double DaireAlanHesapla()
        {
            return Math.PI * r;
        }
    }


    class Silindir : Daire
    {
        public int h { get; set; }

        public double SilindirHacimHesapla()
        {
            return base.DaireAlanHesapla() * h;
        }
    }


    class Koni : Silindir
    {

        public double KoniHacimHesapla()
        {
            return base.SilindirHacimHesapla() / 3;
        }
    }

    class Depo
    {
        private string[] _depo = new string[10];

        public string this[int indis]
        {
            get
            {
                return _depo[indis];
            }
            set
            {
                _depo[indis] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Inheritance(Miras,Kalıtım,Türetme)
            //Asker asker = new Asker();
            //Er er = new Er();


            //Daire daire = new Daire() { r = 5 };
            //Console.WriteLine("Daire Sonuç: " + daire.DaireAlanHesapla());

            //Silindir silindir = new Silindir() { h = 10, r = 3 };
            //Console.WriteLine("Silindir Sonuç: " + silindir.SilindirHacimHesapla());

            //Koni koni = new Koni() { h = 10, r = 3 };
            //Console.WriteLine("Koni Sonuç: " + koni.KoniHacimHesapla());


            //Depo depo = new Depo();
            //depo[0] = "";



        }
    }
}

