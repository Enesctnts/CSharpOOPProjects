using System;
using System.Threading;

namespace Events2
{
    public delegate void Temsilci();
    class Isitici
    {
        public int Isı { get; set; }

        public event Temsilci Kabarciklanma;
        public event Temsilci SesCikar;
        public event Temsilci Fokurdama;

        public void Calistir()
        {
            for (int i = 0; i < 120; i++)
            {
                Thread.Sleep(50);
                Isı++;
                Console.WriteLine(Isı);

                if (Isı >= 30 && Isı < 50 && Kabarciklanma != null)
                {
                    Kabarciklanma();//Temsilci boş olamaz.
                }
                if (Isı >= 50 && Isı <80 && SesCikar != null)
                {
                    SesCikar();//Temsilci boş olamaz.
                }
                if (Isı >= 80 && Isı < 110 && Fokurdama != null)
                {
                    Fokurdama();//Temsilci boş olamaz.
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Isitici ısitici = new Isitici();

            ısitici.Kabarciklanma += Isitici_Kabarciklanma;
            ısitici.SesCikar += Isitici_SesCikar;
            ısitici.Fokurdama += Isitici_Fokurdama;            

            ısitici.Calistir();
        }

        private static void Isitici_Fokurdama()
        {
            Console.WriteLine(" fokur fokur ");
        }

        private static void Isitici_SesCikar()
        {
            Console.WriteLine(" s s s s s s s s s s");
        }

        private static void Isitici_Kabarciklanma()
        {
            Console.WriteLine(" o o o o o o o o o o");
        }
    }
}
