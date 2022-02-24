using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSorgular
{
    public class Urun
    {
        public int UrunID { get; set; }
        public int KategoriID { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return $" UrunID: {UrunID} UrunAdi: {UrunAdi}  Fiyat: {Fiyat}";
        }
    }
}
