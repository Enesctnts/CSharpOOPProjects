using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceV3
{
    public abstract class Arac
    {
        public ConsoleColor Renk { get; set; }

        public Arac()
        {
            Random rnd = new Random();
            Thread.Sleep(100);
            Renk = (ConsoleColor)rnd.Next(1, 15);
        }

    }
}
