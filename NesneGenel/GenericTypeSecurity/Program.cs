using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeSecurity
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList list1 = new ArrayList() { 1, 4, 6, 8, 9, "on"};// ArrayList object tipinde istediği için int dizisine string değer eklenince kabul ediyor ama Run-Time yani çalıştırırken hata verir.
            List<int> list2 = new List<int> { 1, 4, 6, 8, 9}; //  generic liste "on" ifadesi string değer oldugu için kabul etmiyor.Çünkü tipi int olarak tanımlamıştık bu olay bize hatayı yönetimi sağlar.

            int toplam = 0;
            foreach (int sayi in list1)
                toplam += sayi;
            
            Console.WriteLine("ArrayList Toplam: " +toplam);

            toplam = 0;
            foreach (int sayi in list2)
                toplam += sayi;

            Console.WriteLine("List<> Toplam: " + toplam);

        }
    }
}
