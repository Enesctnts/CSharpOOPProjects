using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Deneme<T>
    {
        public void IslmeA(T t)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Deneme<string> deneme = new Deneme<string>();


            //Generic metod oluşturma 

            //int[] Sayilar= { 1, 5, 45, 12 };
            //string[] Sehirler = { "Ankara" , "Istanbul", "Sivas","Yozgat" };
            //double[] Ondalikli = { 10.5 , 50.4 , 45.1 , 12.23 , 3.57 };

            //IslemYap(Sayilar); //Run-Time çalışırken değeri anlar
            //IslemYap<double>(Ondalikli);//Desing-Time Yazarken değeri verdiğimiz için yazarken anlar.
            //IslemYap<string>(Sehirler);//Desing-Time Yazarken değeri verdiğimiz için yazarken anlar.

        }

        static void IslemYap<T>(T[] dizi)
        {
            foreach (T item in dizi)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
