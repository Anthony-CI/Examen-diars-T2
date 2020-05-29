using AnthonyCoronadoIpanaqué.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.DB.Configuracion
{
    public class PeliculaConfiguracion : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            builder.ToTable("Pelicula");
            builder.HasKey(o => o.IdPelicula);

            builder.HasOne(o => o.Director)
                .WithMany(o => o.Peliculas)
                .HasForeignKey(o => o.DirectorId);
        }
    }
}
