using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceV3
{
    public class Mustang:Arac,IBoyanabilir
    {

        public Mustang()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Mustang");
        }
    }
}
