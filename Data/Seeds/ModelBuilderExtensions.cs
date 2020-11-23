using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;

namespace Data.Seeds
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {



            ////https://medium.com/@sacchitiellogiovanni/ef-core-e-ddd-mapeando-e-criando-seeds-com-objetos-de-valor-f26fc5d73a94



            //modelBuilder.Entity<Especie>().HasData(
            //new Especie()
            //{
            //    IdEspecie = 1,
            //    Descricao = "Caesalpinia peltophoroides"
            //},
            // new Especie()
            // {
            //     IdEspecie = 1,
            //     Descricao = "Caesalpinia peltophoroides"
            // },
            //  new Especie()
            //  {
            //      IdEspecie = 3,
            //      Descricao = "Erythrina speciosa"
            //  }
            //);

            //modelBuilder.Entity<Arvore>().HasData(
            //new Arvore()
            //{
            //    IdArvore = 2,
            //    Descricao = "Quaresmeira",
            //    Idade = 30,
            //    Especie = especie2
            //},
            //new Arvore()
            //{
            //    IdArvore = 2,
            //    Descricao = "Pata de Vaca",
            //    Idade = 100,
            //    Especie = especie1
            //},
            //new Arvore()
            //{
            //    IdArvore = 3,
            //    Descricao = "Pata de Vaca",
            //    Idade = 100,
            //    Especie = especie3
            //}

            //);
        }
    }
}
