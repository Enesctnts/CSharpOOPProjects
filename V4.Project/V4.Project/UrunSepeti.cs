using System;
using System.Collections.Generic;
using System.Text;

namespace V4.Project
{
    public class UrunSepeti
    {
        public int SepetId { get; set; }
        public int MusteriId { get; set; }

        public List<Urun> UrunlerListesi = new List<Urun>();
    }
}