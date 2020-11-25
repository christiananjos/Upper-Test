using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Maps
{
    public class GrupoArvoresMap : IEntityTypeConfiguration<GrupoArvores>
    {
        public void Configure(EntityTypeBuilder<GrupoArvores> builder)
        {
            builder.HasKey(x => x.IdGrupoArvores);
            //builder.Property(x => x.IdGrupoArvores).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                    .HasColumnType("Varchar(100)")
                    .IsRequired();

            builder.Property(x => x.Descricao)
                   .HasColumnType("Varchar(100)")
                   .IsRequired();
        }
    }
}
