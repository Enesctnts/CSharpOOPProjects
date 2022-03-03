using EntityFrameworkCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.DAL
{
    public class FilmDB:DbContext
    {
        public FilmDB()
        {
            Database.SetInitializer(new InitDB());
        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<FilmOyuncu> FilmOyuncu { get; set; }


    }
}
