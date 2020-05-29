using AnthonyCoronadoIpanaqué.DB.Configuracion;
using AnthonyCoronadoIpanaqué.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.DB
{
    public class AppPruebaContex : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Director> Directores { get; set; }
        public DbSet<Favorito> Favoritos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Examen;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioConfiguracion());
            modelBuilder.ApplyConfiguration(new PeliculaConfiguracion());
            modelBuilder.ApplyConfiguration(new DirectorConfiguracion());
            modelBuilder.ApplyConfiguration(new FavoritoConfiguracion());

        }
    }
}
