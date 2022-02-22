using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGenericFark
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList liste1 = new ArrayList();
            List<int> liste2 = new List<int>();

            DateTime basla, bitir;
            TimeSpan fark;

            basla = DateTime.Now;
            for (int i = 0; i < 9999999; i++)
            {
                liste1.Add(i);//Burada boxing ve unboxing olayı oldugu için ArrayList daha yavaş çalışır çünkü object olarak değer istiyo o yüzden kutulama yapıyoruz. generic kısımda ise direk int tipini verdiğimiz için daha hızlı çalışır.
                int sayi = (int)liste1[i];
            }
            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine($"İşlem zamanı(ArrayList) {fark.TotalMilliseconds}");



            basla = DateTime.Now;
            for (int i = 0; i < 9999999; i++)
            {
                liste2.Add(i);
                int sayi = liste2[i];
            }
            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine($"İşlem zamanı(List<>) {fark.TotalMilliseconds}");

        }
    }
}
