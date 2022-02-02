using System;
using System.Collections.Generic;
using System.Text;

namespace SahibindenDemo.Sahibinden
{
    enum KasaTipi
    {
        Dikey,
        Yatay,
        ThinClient
    }
    class Masaustu:Bilgisayar
    {
        private bool _MonitorVarMi;
        private KasaTipi _KasaTipi;

        public bool MonitorVarmi{ get => _MonitorVarMi; set=> _MonitorVarMi = value; }
        public KasaTipi KasaTipi { get => _KasaTipi; set => _KasaTipi = value; }

        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine("\n******** ÜRÜN BİLGİLERİ         ******\n");
            Console.WriteLine("Marka  :" + base.Marka);
            Console.WriteLine("İşlemci: " + base.Islemci);
            Console.WriteLine("Bellek :" + base.Bellek);
            Console.WriteLine("HDD    :" + base.HDD);
            Console.WriteLine("SSD    :" + base.SSD);
            string monitor = "Yok";
            if (MonitorVarmi)
                monitor = "Var";
            Console.WriteLine("Monitör    :" + monitor);
            Console.WriteLine("KasaTipi   :" + KasaTipi);
            Console.WriteLine("\n**************************************\n");

            
        }

    }
}
