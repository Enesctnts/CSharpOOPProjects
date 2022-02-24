using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSordular2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception Handling(istisnaların yakalanması)
            //uygulama çalışırken rutinin dışında uygulamanın sonlanlandırılması istisna denir.

            int a, b, c;
            a = 10;
            b = 0;
            c = 0;

            //c = a / b;
            //Console.WriteLine("Bolmeden sonraki işlemler");
            //Console.WriteLine(c);

            //b = 0;
            //c = a / b; //İstenmeyen Durum... Kodun kırılması en istenmeyen durumdur.
            //Console.WriteLine(c);
            //Try catch kullanmalıyız ama bir projede ne kadar fazla try catch kullanırsa sistem çok yavaşlar çünkü CPU hatayı bulabilmek için kendini çok yavaşlatıyor o yüzden proje yavaşlar.

            // Hatayı yakalamak için ve kodun kırılmaması için aşagıdaki yöntem uygulanır.
            //try
            //{
            //    c = a / b;
            //}
            //catch
            //{
            //    Console.WriteLine("ISTISNAI Bir durum oluştu...");            
            //}

            //Console.WriteLine(c);


            int[] sayilar = { 3, 6, 7, 1 };

            try
            {
                int s = sayilar[10]; // ilk hangi hatayı görürse onun catch komutu çalışır.
                c = a / b;
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dosyaya Yaz..Sıfıra bolünme");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("SMS Gonder..Index out of range");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Bolmeden sonraki islemler");
            Console.WriteLine(c);
        }
    }
}
