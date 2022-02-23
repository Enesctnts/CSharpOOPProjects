using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateV2
{
    class Program
    {
        delegate int Temsilci();
        delegate void Temsilci1();

        public static int MetodA()
        {
            return 4;
        }
        public static int MetodB()
        {
            return 1;
        }
        public static int MetodC()
        {
            return 5;
        }



        
        static bool TekSayiMi(int sayi)
        {
            return sayi % 2 == 1;
        }

        static void Yaz(List<int> sayilar)
        {
            Console.WriteLine();
            foreach (int s in sayilar)
            {
                Console.Write(s + " ");
            }
        }
        static void Islem(){ }
        static void Main(string[] args)
        {
            Temsilci t = new Temsilci(MetodA);
            t += new Temsilci(MetodB);//böylede yapılabilir
            t += MetodC;//bu şekilde de yapılabilir

            //Console.WriteLine(t()); // Consolda değeri görüntüleyince en son eklenen değer gözükür.
            //Multicase delegelerde birden fazla metod olur bunları döndürmeye çalışırsak en son değer gözükür sadece. multicase delegelerde return type var ise o zaman void döndürülür ve eventhandler ile diğer metodları kaybolmadan getirebiliriz.Eventhandler araştır..



            List<int> sayilar = new List<int>() { 2, 3, 5, 6, 8, 45, 1, 15, 65 };
            //Klasik YÖntem
            Console.WriteLine("Klasik Yöntemi");
            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilar[i]%2==1)
                {
                    Console.Write(sayilar[i] + " ");
                }
            }
            Console.WriteLine("\n");

            

            //1.Yöntem
            Console.Write("Predicate Yöntemi");
            Predicate<int> p = new Predicate<int>(TekSayiMi);
            Yaz(sayilar.FindAll(p));


            //2.Yöntem
            //Yaz(sayilar.FindAll(Islem));// Islem metodu return type kuralına uymadıgı için çalışmaz.!! 
            Console.Write("\n\n2.Yöntem");
            Yaz(sayilar.FindAll(TekSayiMi));


            //Anonim Metodlar ---->  Ananım metod metod içinde metod tanımlama t2() diyeerek çagırılır
            Console.WriteLine("\n\n***Ananim Metod***");
            Temsilci1 t2 = delegate()
            {
                Console.WriteLine("Ananım metod");
            };

            t2();
            Console.WriteLine();


            //3.Yöntem
            Console.Write("3. Yöntem");
            Yaz(sayilar.FindAll(delegate (int s)
            {
                return s % 2 == 1;
            }));

            Console.WriteLine("\n");


            //4.Yöntem 
            Console.Write("4. Yöntem");
            Yaz(sayilar.FindAll(s => s%2==1));
            Console.WriteLine("\n");
        }
    }
}
