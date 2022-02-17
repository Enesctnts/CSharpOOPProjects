using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Daire
    {
        public double r { get; set; }

        public Daire(double r)
        {
            this.r = r;
        }
        public virtual double Hesapla()
        {
            return Math.PI * r;
        }
        
    }


    class Silindir : Daire
    {
        public int h { get; set; }

        public Silindir(int  h,double r):base(r)
        {
            this.h = h;
        }
        public override double Hesapla()
        {
            return base.Hesapla()*h;
        }
    }


    class Koni : Silindir
    {
        public Koni(int h , double r):base(h,r)
        {

        }
        public override double Hesapla()
        {
            return base.Hesapla() * 0.333333;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Daire daire = new Daire(3);
            Silindir silindir = new Silindir(10,3);
            Koni koni = new Koni(10,3);


            Console.WriteLine(daire.Hesapla());
            Console.WriteLine(silindir.Hesapla());
            Console.WriteLine(koni.Hesapla());
        }
    }
}
