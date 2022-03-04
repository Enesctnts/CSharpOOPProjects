using EntityFrameworkCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.DAL
{
    public class InitDB:DropCreateDatabaseAlways<FilmDB>
    {
        protected override void Seed(FilmDB context)
        {

            context.Yonetmenler.Add(new Yonetmen { YonetmenAdi = "Spielberg" });
            context.Yonetmenler.Add(new Yonetmen { YonetmenAdi = "Fincher" });

            context.Kategoriler.Add(new Kategori { KategoriAdi = "Bilim Kurgu" });
            context.Kategoriler.Add(new Kategori { KategoriAdi = "Gerilim" });
            context.Kategoriler.Add(new Kategori { KategoriAdi = "Komedi" });
            context.Kategoriler.Add(new Kategori { KategoriAdi = "Dram" });

            context.Oyuncular.Add(new Oyuncu{ OyuncuAdi="Tom Hanks" , Cinsiyet="Erkek"});
            context.Oyuncular.Add(new Oyuncu{ OyuncuAdi="Brad Pitt" , Cinsiyet="Erkek"});
            context.Oyuncular.Add(new Oyuncu{ OyuncuAdi="Scarlett Johnson" , Cinsiyet="Kadın"});
            context.Oyuncular.Add(new Oyuncu{ OyuncuAdi="Al Pacino" , Cinsiyet="Erkek"});
            context.Oyuncular.Add(new Oyuncu{ OyuncuAdi="Jennifer Lawrance" , Cinsiyet="Kadın"});

            context.SaveChanges();

            context.Filmler.Add(new Film { FilmAdi = "Forrest Gump", Sure = 120, KategoriID = 4, YonetmenID = 1 });
            context.Filmler.Add(new Film { FilmAdi = "The God Father II", Sure = 125, KategoriID = 4, YonetmenID = 2 });
            context.Filmler.Add(new Film { FilmAdi = "Lucy", Sure = 110, KategoriID = 4, YonetmenID = 2 });


            context.FilmOyuncu.Add(new FilmOyuncu { FilmID = 1, OyuncuID = 1, RolAdi = "Forrest" });
            context.FilmOyuncu.Add(new FilmOyuncu { FilmID = 2, OyuncuID = 4, RolAdi = "Micheal" });



            context.SaveChanges();

        }
    }
}
