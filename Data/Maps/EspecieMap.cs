using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Maps
{
    public class EspecieMap : IEntityTypeConfiguration<Especie>
    {
        public void Configure(EntityTypeBuilder<Especie> builder)
        {
            builder.HasKey(x => x.IdEspecie);
            builder.Property(x => x.IdEspecie).ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao)
                    .HasColumnType("Varchar(100)");

        }
    }
}
