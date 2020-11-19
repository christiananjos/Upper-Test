using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Maps
{
    public class EspecieMap : IEntityTypeConfiguration<Especie>
    {
        public void Configure(EntityTypeBuilder<Especie> builder)
        {
            builder.HasKey(x => x.IdEspecie);
            builder.Property(x => x.IdEspecie).ValueGeneratedOnAdd();

            builder.Property(x => x.Descricao)
                    .HasColumnType("Varchar(100)")
                    .IsRequired();

        }
    }
}
