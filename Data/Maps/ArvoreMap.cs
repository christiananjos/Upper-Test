﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Maps
{
    public class ArvoreMap : IEntityTypeConfiguration<Arvore>
    {
        public void Configure(EntityTypeBuilder<Arvore> builder)
        {
            builder.HasKey(x => x.IdArvore);
            builder.Property(x => x.IdArvore).ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao)
                    .HasColumnType("Varchar(100)");

            builder.Property(x => x.Idade)
                   .HasColumnType("Int");

           
        }
    }
}
