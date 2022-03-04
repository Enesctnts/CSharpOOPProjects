using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EfCodeFirstDatabaseFirst
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Kitaplar> Kitaplar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yazarlar> Yazarlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategoriler>()
                .Property(e => e.KategoriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Kitaplar>()
                .Property(e => e.KitapAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Yazarlar>()
                .Property(e => e.YazarAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Yazarlar>()
                .Property(e => e.YazarSoyad)
                .IsUnicode(false);
        }
    }
}
