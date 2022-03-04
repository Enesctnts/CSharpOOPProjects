using BusinessGeneric.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGeneric.DAL
{
    public class GenericFilmDB:DbContext
    {

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }
        public DbSet<Kategori> kategoriler { get; set; }


    }
}
