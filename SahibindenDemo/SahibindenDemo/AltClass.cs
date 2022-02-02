using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibindenDemo
{
    class AltClass : AnaClass // Kalıtım yoluyla Miras aldık.
    {
        private string _AdSoyad;
        public string AdSoyad
        {
            get { return _AdSoyad; }
            set { _AdSoyad = value; }
        }
        public AltClass()
        {

        }
        public AltClass
            (int id, DateTime kayitTarihi, string adSoyad) : base(id, kayitTarihi)
        {
            _AdSoyad = adSoyad;
        }

        public void AdSoyadYaz()
        {
            Console.WriteLine("Ad Soyad:" + AdSoyad);
        }
        new public void BilgiYaz()
        {
            base.BilgiYaz(); // Ana sınıftaki BilgiYaz metodunu çağırdık.
            Console.WriteLine(base.Test);
            Console.WriteLine("Ad Soyad:" + AdSoyad);
        }
    }
}
