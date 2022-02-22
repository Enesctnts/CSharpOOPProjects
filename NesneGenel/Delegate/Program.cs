using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatee
{
    class Program
    {
        delegate void temsilci();

        static public void Mesaj()
        {
            Console.WriteLine("Mesajjj");
        }
        static public void Gunaydın()
        {
            Console.WriteLine("Gunaydınnn");
        }
        static public void Merhaba(string str)
        {
            Console.WriteLine("Merhabaaa");
        }
        static public string Hi()
        {
            return "Hi!!";
        }


        static void Main(string[] args)
        {
            //Delegate : Temsilci  -- Metodları taşımak için kullanılır. 1 veya 1'den fazla metodu taşımak için kullanılır.
            //Delegate metodların imzası ve return type aynı olanları taşır. 2 tane en öenmli delegate vardır.
            //func<> metod geriye değer döndürüyosa func<> delegate kullanıyoruz.
            //Action<> metod geriye değer dönmüyorsa Action<> delegate kullanılır.
            //bir delegenin içinde birden fazla metod varsa multikeysDelegate diye geçer

            temsilci t = new temsilci(Mesaj);
            t += Mesaj;
            t += Gunaydın;
            //t +=Hi return type yanlışş...
            //t += Merhaba; // İmzası yanlış..
            //t -= Mesaj;

            //t();// Metodları çagırma işlemi

            foreach (Delegate del in t.GetInvocationList())
            {
                Console.WriteLine(del.Method.Name);
                if (del.Method.Name != "Mesaj")
                {
                    del.DynamicInvoke();
                }
            }

        }
    }
}
