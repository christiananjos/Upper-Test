using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Repositories
{
    public class EspecieRepository<Especie> : IRepository<Especie> where Especie : class
    {
        public void Create(Especie entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Especie entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Especie entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Especie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Especie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
