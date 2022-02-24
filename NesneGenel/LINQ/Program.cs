using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        class Personel
        {
            public int PerId { get; set; }
            public string PerAdı { get; set; }
        }
        static void Main(string[] args)
        {
            //LINQ
            //1-var
            var sayi = 12;
            var ad = "Cevdet";
            var kontrol = true;
            var pers = new Personel();
            var fiyat = 9.99M;
            var karakter = 'A';

            //sayi = "naber"; // var ile tanımlanan bir değer sonradan tip olarak değiştirilemez ilk tipi belirlendiği haliyle devam edilir
            //C# 4.0
            dynamic deger = 12;//dynamic olarak tanımlanırsa deger tipi int olmasına ragmen sonradan tipini değiştirebiliyoruz.
            deger = "value";// int tipi string tipe çevirdi

            object degisken1 = 15;
            int sayi1 = (int)degisken1;  //object türünde bişey tanımlanırsa sonradan dönüşüm yapılması gerekiyor.

            dynamic degisken2 = 19;
            int sayi2 = degisken2;// dynamic tipinde tanımlanınca int bir degere atınca tanımlama yapılabiliyor. dynamic yapılınca tanımlanan değerin tipinide tuttugu için direk int bir değere eşitlenebiliyor.


            //2-Auto property
            //public int MyProperty { get; set; }

            //3- Object Inıt. --> newlerken {} süslü parantez içine yazdıgımız atamalar.. zorunlu kılmak için.
            //constructor ile ilk  deger atamak için object Inıt. kullanılır.
            //Personel personel = new Personel() { PerAdı = "Enes", PerId = 1 };

            //4-Collection Inıt.
            //bir kolleksiyona ilk değer vermek için constructurla değer ataması gerçekleştirilir.
            //List<Personel> personeller = new List<Personel>
            //{
            //    new Personel{ PerId =111 , PerAdı="Emre"},
            //    new Personel{ PerId= 222 , PerAdı = "Yunus"}
            //};

            //5-Anonim Nesne
            //var nesne = new { ID = 123, Ad = " Cevdet ", Maas = 4567 }; 
            // Bir class oluşturmadan property tanımlamadan ananim nesne oluşturulur ve bu anonim nesne classımızdır. Süslü parantez içinde yazılan değerler property olarak tanımlanır.

            
            


        }
    }
}
