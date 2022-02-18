using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnek
{
    public enum Gunler
    {
        pazartesi=1,salı,çarşamba,perşembe,cuma,cumartesi,pazar
    }
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 8; i++)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine((Gunler)i);
            }

        }
    }
}
