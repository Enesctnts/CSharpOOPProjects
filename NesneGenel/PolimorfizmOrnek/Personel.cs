using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{
    public class Personel
    {

        public int PerId { get; set; }
        public string PerAdi { get; set; }

        public override string ToString()
        {
            return PerId + " " + PerAdi;
        }

        
    }
}
