using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{
    public class Musteri
    {
        public int MusID { get; set; }
        public string MusAdi { get; set; }

        public override string ToString()
        {
            return MusID + " " + MusAdi;
        }

    }
}
