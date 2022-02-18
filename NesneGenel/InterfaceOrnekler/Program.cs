using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnekler
{
   
    class Depo :IEnumerable
    {

        string[] _urunler = { "Urun1", "Urun2", "Urun3", "Urun4" };

        public IEnumerator GetEnumerator()
        {
            return _urunler.GetEnumerator();
        }
        
    }

    class Urun:IComparable
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public int CompareTo(object obj)
        {
            Urun urun = (Urun)obj;
            return -1*UrunID.CompareTo(urun.UrunID); // strcmp komutunda == 0 eşit oldugunda herşey eşit ==-1 oldugunda 2 ci büyük olana göre sıralıyor == 1 olunca küçükten büyüğe sıraladık burda -1 çarpmamızın sebebi Id göre sıraladık şimdi -1 çarpıp tersten yazdırıyoz.
        }
        public override string ToString()
        {
            return UrunID + " " + UrunAdi + " " + Fiyat;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Depo depo = new Depo();
            //foreach (var s in depo)
            //{
            //    Console.WriteLine(s);
            //}


            //ArrayList list1 = new ArrayList() { 15,55,1,515,20,2,6,3,54};

            //list1.Sort();

            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList list2 = new ArrayList() {"Bursa" , "Ankara", "Istanbul" , "Yozgat" , " Sivas" , "Afyon" , "Konya"};

            //list2.Sort();

            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //Sıralama
            ArrayList list3 = new ArrayList() 
            { 
                new Urun{UrunID=1,UrunAdi="Kalem",Fiyat=20 },
                new Urun{UrunID=2,UrunAdi="Silgi",Fiyat=15 },
                new Urun{UrunID=3,UrunAdi="Masa",Fiyat=25 },

            };

            list3.Sort();
            

            foreach (Urun item in list3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
