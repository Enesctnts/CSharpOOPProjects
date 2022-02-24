using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSorgular
{
    class Program
    {
        static void Yaz<T>(List<T> liste)
        {
            foreach (T t in liste)
            {
                Console.WriteLine(t);
            }
        }
        static void Main(string[] args)
        {
            //LINQ 
            //1-SQL gibi..

            //var sonuc = from u in UrunData.Urunler
            //            select u;

            //Yaz(sonuc.ToList());



            //int ID = 126;
            //var sonuc = from u in UrunData.Urunler
            //            where u.UrunID == ID
            //            select u;
                                                    //Yandaki kodda ilk ID=126 ya göre veriyi getir diyoruz ama ID=128 e göre sıralıcak                     çünkü ToList() ifadesini görene kadar ID=128  oldugu için onu sıralayıp getirdi
            //ID = 128;
            //Yaz(sonuc.ToList());




            //int ID2 = 126;
            //var sonuc2 = (from u in UrunData.Urunler
            //            where u.UrunID == ID2
            //            select u).ToList();
            //                                //Yandaki kodda ilk ID=126 ya göre veriyi getir diyoruz ve altaki satırda  ID=128'i görmeden                                  ToList() i gördüğü için ID=126 ya göre getiriyor. yani ToList() gördüğü anda en son hangi ID                                    verilmişse o Id deki değerler gelir.
            //ID2 = 128;
            //Yaz(sonuc2);



            //2.Expression Tree şeklinde...
            //var sonuc = UrunData.Urunler.Where(u => u.UrunID == 128).ToList();
            //Yaz(sonuc);




            //var sonuc = UrunData.Kategoriler.Select(u => u).ToList();

            //var sonuc = from u in UrunData.Urunler
            // select new { ID = u.UrunID, Ad = u.UrunAdi }; //1.yol Anonim Nesne Oluşturarak getiriyoruz

            //Select new derken yeni tablo gibi oluşturup getiriyoruz.

            //var sonuc = UrunData.Urunler.Select(u => new { u.UrunID, u.UrunAdi });//2.yol Anonim Nesne Oluşturarak getiriyoruz
            //Yaz(sonuc.ToList());

            //Joın 
            //SQL sorgusuyla yapma
            //var sonuc = from u in UrunData.Urunler
            //            join k in UrunData.Kategoriler
            //            on u.KategoriID equals k.KategoriID
            //            select new { u.UrunID, u.UrunAdi, k.KategoriAdi };

            //Yaz(sonuc.ToList());
            //Expression Tree yöntemiyle yapma
            //var sonuc = UrunData.Urunler.Join(UrunData.Kategoriler, u => u.KategoriID, k => k.KategoriID, (u, k) => new { u.UrunID, u.UrunAdi, k.KategoriID });

            //Yaz(sonuc.ToList());




        }
    }
}
