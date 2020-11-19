using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seeds
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            var especie1 = new Especie("Caesalpinia peltophoroides");
            var especie2 = new Especie("Campomanesia phaea");
            var especie3 = new Especie("Erythrina speciosa");


            var arvore1 = new Arvore("Pata de Vaca", 100, especie1);
            var arvore2 = new Arvore("Quaresmeira", 30, especie2);
            var arvore3 = new Arvore("Jacarandá de Minas", 350, especie3);





            modelBuilder.Entity<Arvore>().HasData(
                arvore1,
                arvore2,
                arvore3
            );
        }
    }
}
