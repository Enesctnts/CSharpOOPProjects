using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceV4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add(new Penguen());
            liste.Add(new Pelikan());
            liste.Add(new Hamsi());
            liste.Add(new Kedi());
            liste.Add(new Kanarya());


            foreach (object obj in liste)
            {
                if (obj is IYuzebilir)
                {
                    Console.WriteLine(obj.ToString());
                }

            }
            Console.WriteLine("\n-----------------------------------------------\n");
            foreach (object obj in liste)
            {
                if (obj is IUcabilir)
                {
                    Console.WriteLine(obj.ToString());
                }

            }
        }
    }
}
