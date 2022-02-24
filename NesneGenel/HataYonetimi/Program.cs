using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5, c = 0;

            try
            {
                b = 0;
                c = a / b;//burada hata olursa alttaki Console.WriteLine("ISTISNADAN Sonra..."); komutunu çalıştırmaz..
                Console.WriteLine("ISTISNADAN Sonra..."); 

            }
            catch(Exception ex)
            {
                Console.WriteLine("ISTISNAI Bir durum var..");
            }
            finally
            {
                //Hata olsada olmasada çalışıcak  bölüm
                Console.WriteLine("Ne olursa olsun çalış...");
            }
        }
    }
}
