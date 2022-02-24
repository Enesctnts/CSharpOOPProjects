using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LİNQV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //6-Extension Methods(Genişletme metodlari...)
            //Extension Methods yazmanın kuralları
            //1-Static bir class olmalı..
            //2-Mutlaka static sınıf içerisindeki metodlarda static olmalı..
            //3-Metodun olması this ile başlamalı, ilgili yapılara eklenmelidir.

            //Extension Methods Genişletmeye yarar int tipinde kareal metodu oluşturduk bundan sonraki bütün int değerlerde kare al metodu geliyor aşagı ok işaretiyle gösterilir ama int değerlerde Terscevir metodu gözükmez çünkü string sadece tanımlanan metod tipi ne ise o tiplerdeki değişkenlerde gözükür..

            //Koleksiyonlar--> IEnumerable interfacenin implement edildigi her yerde kullanılır.

            int sayi = 12;
            Console.WriteLine(sayi.KareAl());

            string str = "deneme";
            Console.WriteLine(str.TersCevir());


            string strMesaj = "Merhaba";
            Console.WriteLine(strMesaj.Eko(3)); //Extension Methods'da parametreli kullanım.


            //7-Expression Tree
            //LINQ sorhularında 2 şekilde yazılır.. ASıl olan Expression Tree yöntemi
            //2. ise SQL cümlesi gibi

            //Expression Tree
            int sayi5 = 2;
            sayi5.KareAl().KupAl().IkiyeBol();//Birden fazla metodu aynı anda kullanabilme


            //8-Lambda Expressions "=>" --> bu işareti gördüğümüz yerde delege vardır.
            int[] sayilar = { 3, 5, 6, 8, 1, 10 };
            foreach (var item in sayilar.Where(s=>s%2==1))//Lambda Exp kullanılımı
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(sayilar.Where(s=> s%2==1).Sum()); //Lambda Exp kullanılımı





        }
    }
}
