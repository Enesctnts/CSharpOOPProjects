using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KitapBLL
    {
        //Dependency Injection uygulanmalı....

        KitapDB db = new KitapDB();
        public void KitapEkle(Kitap kitap)
        {
            db.Kitaplar.Ekle(kitap);
        }

        public List<Kitap> KitapListe()
        {
            return db.Kitaplar.Liste();
        }

        public List<Kitap> KitapListeKategori(int katID)
        {
            return db.Kitaplar.Liste().Where(k => k.KategoriID == katID).ToList();
        }

        public List<Kitap> KitapListeYazar(int yazID)
        {
            return db.Kitaplar.Liste().Where(k => k.YazarID == yazID).ToList();
        }



    }
}
