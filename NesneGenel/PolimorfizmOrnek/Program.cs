using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            p.PerAdi = "Enes";
            p.PerId = 1;
            Musteri m = new Musteri { MusAdi="Emre" , MusID =2};
            
            Console.WriteLine(p);
            Console.WriteLine(m);
            

        }
    }
}
