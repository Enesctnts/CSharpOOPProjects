using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Constraints
{
    abstract class Sekil
    {

    }
    class Kare:Sekil
    {

    }
    class Kup:Kare,IHacim
    {

    }
    class Ferrari
    {

    }
    class Cizim<T> where T : Sekil 
    {

    }
    class Deneme<T> where T : struct
    {

    }
    class Emened<T> where T:class
    {

    }

    interface IHacim { }

    class HacimHesapla<T> where T : IHacim { }

    class Emlak<T> where T: new()
    {

    }
    class Ev 
    {
        public Ev(string adres)
        {

        }
    }

    class Karavan 
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

            //1-Struct
            //2-class
            //3-Inheritance
            //4-Interface
            //5-new()


            //1-Struct
            Deneme<int> d1 = new Deneme<int>();
            Deneme<bool> d2 = new Deneme<bool>();
            // Deneme<struct> d3 = new Deneme<struct>(); string referans tip oldugu için kabul edilmiyor.

            //2-class
            Emened<string> e1 = new Emened<string>();
            Emened<object> e2 = new Emened<object>();
            //Emened<int> e3 = new Emened<int>(); int değer tip oldugu için kabul edilmiyor

            //3-Inheritance
            Cizim<Kare> c1 = new Cizim<Kare>();
            Cizim<Kup> c2 = new Cizim<Kup>();
            //Cizim<Ferrari> c3 = new Cizim<Ferrari>();//Ferrari Sekil classından türemediği için kullanılamıyor

            //4-Interface
            //HacimHesapla<Kare> hh1 = new HacimHesapla<Kare>(); Kare IHacimden iplement olmadıgı için hata verir
            HacimHesapla<Kup> hh2 = new HacimHesapla<Kup>();

            //new()
            //Tüm ksııtlar içerisinde new mutlaka en sonda olmalı
            //Emlak<Ev> ev = new Emlak<Ev>(); // Default ctor yok.. 
            Emlak<Karavan> karavan = new Emlak<Karavan>();


        }
    }
}
