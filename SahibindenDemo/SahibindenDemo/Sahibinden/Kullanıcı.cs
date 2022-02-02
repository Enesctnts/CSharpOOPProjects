using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahibindenDemo.Sahibinden
{
    class Kullanici
    {
        private int _ID;
        public int ID { get { return _ID; } }
        private string _AdSoyad;
        public string AdSoyad
        {
            get { return _AdSoyad; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _AdSoyad = value;
            }

        }
        private string _Telefon;
        public string Telefon
        {
            get { return _Telefon; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _Telefon = value;
            }

        }
    }
}
