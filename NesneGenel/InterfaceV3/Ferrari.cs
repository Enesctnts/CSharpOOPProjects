using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceV3
{
    public class Ferrari:Arac,IBoyanabilir
    {
        public Ferrari()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Ferrari");
        }
    }
}
