using AnthonyCoronadoIpanaqué.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.DB.Configuracion
{
    public class FavoritoConfiguracion : IEntityTypeConfiguration<Favorito>
    {
        public void Configure(EntityTypeBuilder<Favorito> builder)
        {
            builder.ToTable("Favorito");
            builder.HasKey(o => o.IdFavorito);

            builder.HasOne(o => o.Pelicula)
                .WithMany(o => o.Favoritos)
                .HasForeignKey(o => o.PeliculaId);
        }
    }
}
