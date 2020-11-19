using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Maps
{
    public class ColheitaMap : IEntityTypeConfiguration<Colheita>
    {
        public void Configure(EntityTypeBuilder<Colheita> builder)
        {
            builder.HasKey(x => x.IdColheita);
            builder.Property(x => x.IdColheita).ValueGeneratedOnAdd();

            builder.Property(x => x.Informações)
                    .HasColumnType("Varchar(100)");

            builder.Property(x => x.DataColheita)
                   .HasColumnType("Date");

            builder.Property(x => x.PesoBruto)
                  .HasColumnType("Money");


        }
    }
}
