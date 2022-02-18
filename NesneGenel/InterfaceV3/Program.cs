using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceV3
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Ferrari ferrari = new Ferrari();
            Mustang mustang = new Mustang();
            BMX bMX = new BMX();

            Boyahane boyahane = new Boyahane();
            boyahane.Boya(ferrari, ConsoleColor.Red);
            boyahane.Boya(mustang, ConsoleColor.Cyan);

            
        }
    }
}
