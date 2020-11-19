using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Maps
{
    public class GrupoArvoresMap : IEntityTypeConfiguration<GrupoArvores>
    {
        public void Configure(EntityTypeBuilder<GrupoArvores> builder)
        {
            builder.HasKey(x => x.IdGrupoArvores);
            builder.Property(x => x.IdGrupoArvores).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                    .HasColumnType("Varchar(100)");

            builder.Property(x => x.Descricao)
                   .HasColumnType("Date");


        }
    }
}
