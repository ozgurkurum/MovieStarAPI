using CodeFirstFilmlerOyuncular.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFilmlerOyuncular.Data
{
    public class FilmOyuncuContext:DbContext
    {
        public FilmOyuncuContext() : base("Baglanti")
        {
           

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oyuncu>()
                .HasOptional(x => x.IletisimBilgi)
                .WithRequired(x => x.Oyuncu);

            modelBuilder.Entity<Film>()
                .Property(x => x.IMDBPuani)
                .HasPrecision(2, 1);
        }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<IletisimBilgi> IletisimBilgileri { get; set; }
    }
}
