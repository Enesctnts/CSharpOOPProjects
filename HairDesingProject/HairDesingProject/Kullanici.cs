using System;
using System.Collections.Generic;
using System.Text;

namespace HairDesingProject
{
    public class Kullanici
    {

        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public Kuafor kuafor { get; set; }

        public Kullanici()
        {
            kuafor = new Kuafor();
        }

    }
}
