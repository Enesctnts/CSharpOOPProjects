using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{

    class Araba
    {
        public virtual void Sur()
        {
            Console.WriteLine("Araba Sur..");
        }
    }

    class Ferrari:Araba
    {
        public override void Sur()
        {
            Console.WriteLine("Ferrari Sur..");
        }
    }

    class Mercedes:Araba
    {
        public override void Sur()
        {
            Console.WriteLine("Mercedes Sur..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            Araba ferrari = new Ferrari();
            Araba mercedes = new Mercedes();

            araba.Sur();
            ferrari.Sur();
            mercedes.Sur();

            //object obj = new Araba();
            //((Ferrari)obj).Sur();

            //var obj = new Araba();
            //(obj).Sur();



        }
    }
}
