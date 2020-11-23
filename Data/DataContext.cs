using Data.Maps;
using Data.Seeds;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class DataContext: DbContext
    {
        public DbSet<Arvore> Arvores { get; set; }
        public DbSet<Colheita> Colheitas { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<GrupoArvores> GrupoArvores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pomar;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArvoreMap());
            modelBuilder.ApplyConfiguration(new ColheitaMap());
            modelBuilder.ApplyConfiguration(new EspecieMap());
            modelBuilder.ApplyConfiguration(new GrupoArvoresMap());

            //modelBuilder.Seed();

        }
    }
}
