using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceV3
{
    public class Boyahane
    {
        public void Boya(IBoyanabilir arac,ConsoleColor yeniRenk)
        {
            Arac arac1 = (Arac)arac;
            arac1.Renk = yeniRenk;

            Console.ForegroundColor = arac1.Renk;
            Console.WriteLine(arac1.GetType().Name + " boyandi...");
        }
    }
}
