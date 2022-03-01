using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.NetV2.Model
{
    public class Yazar
    {
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public  string YazarSoyad   { get; set; }
        public string YazarADSOYAD { get => YazarAd + " " + YazarSoyad; }


    }
}
