using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSorgular
{
    public static class UrunData
    {
        static UrunData()
        {
            List<Urun> _urunler = new List<Urun>()
            {
                
                new Urun(){ UrunID=123,UrunAdi="A4 Defter" , Fiyat=25 , KategoriID=1},
                new Urun(){ UrunID=125,UrunAdi="Cetvel" , Fiyat=25,KategoriID=1},
                new Urun(){ UrunID=126,UrunAdi="Satranç" , Fiyat=75,KategoriID=2},
                new Urun(){ UrunID=128,UrunAdi="Tavla" , Fiyat=60,KategoriID=2}

            };

            List<Kategori> _kategoriler = new List<Kategori>()
            {
                //Collection Inıt --> ilk değer ataması gerçekleştirliyor
                new Kategori{ KategoriID=1, KategoriAdi="Kırtasiye"},
                new Kategori{ KategoriID=2, KategoriAdi="Hobi"}

            };

            //Object Inıt --> ilk değer ataması gerçekleştirliyor
            Urunler = _urunler;
            Kategoriler = _kategoriler;
        }


        static public List<Urun> Urunler { get; set; }
        static public List<Kategori> Kategoriler { get; set; }
    }
}
