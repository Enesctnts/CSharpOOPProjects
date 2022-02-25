using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SDK;

namespace BuyukHarfeCevir
{
    public class BuyukHarfeCevirEfekti : ISDK
    {
        public string EklentiAdi => "Buyuk Harfe Cevir Efekti...";

        public string Islem(string str)
        {
            return str.ToUpper();
        }
    }
}
