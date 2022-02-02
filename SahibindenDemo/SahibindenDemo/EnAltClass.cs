using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibindenDemo
{
    class EnAltClass : AltClass
    {
        private string _Ozellik;
        //public string Ozellik
        //{ get => _Ozellik; set => _Ozellik = value; }
        public string Ozellik
        {
            get { return _Ozellik; }
            set { _Ozellik = value; }
        }
        public EnAltClass() { }
        public EnAltClass(int id, DateTime kayitTarihi, string adSoyad, string ozellik) : base(id, kayitTarihi, adSoyad)
        {
            _Ozellik = ozellik;
        }
        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine(base.Test);
            Console.WriteLine("Ozellik:" + Ozellik);
        }

    }
}
