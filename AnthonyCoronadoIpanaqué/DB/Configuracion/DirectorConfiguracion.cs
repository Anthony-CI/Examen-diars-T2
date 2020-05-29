using AnthonyCoronadoIpanaqué.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthonyCoronadoIpanaqué.DB.Configuracion
{
    public class DirectorConfiguracion : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.ToTable("Director");
            builder.HasKey(o => o.IdDirector);
            builder.Property(o => o.Nombre).HasColumnName("Nombre");
        }
    }
}
