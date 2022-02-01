using System;
using System.Collections.Generic;
using System.Text;
using static V4.Project.Enumlar;

namespace V4.Project
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public UrunKategorileri  UrunKategorisi { get; set; }


    }
}