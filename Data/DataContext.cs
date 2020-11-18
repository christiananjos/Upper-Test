﻿using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}