using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //1- Temsilciyee ihtiyaç vardır yani delegate e ihtiyaç vardir
    //2- O temsilci tipinden event(olay) tanımlanır
    //3- Olayı tetikleyecek mekaizma kurulur..
    //4- Class oluşturulur 
    //5- Olaya metod bağlanır
    //6- Çalıştır..

    delegate void Temsilci();
    class Buton
    {
        public event Temsilci Tikla;

        public void Calistir()
        {
            if (Tikla!=null)
            {
                Tikla();
            }
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Buton btn = new Buton();
            btn.Tikla += Btn_Tikla; ;
            btn.Calistir();

            
        }

        private static void Btn_Tikla()
        {
            Console.WriteLine("Butona tiklandi..");
        }
    }
}
