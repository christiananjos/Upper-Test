using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Repositories
{
    public class ColheitaRepository<Colheita> : IRepository<Colheita> where Colheita : class
    {
        public void Create(Colheita entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Colheita entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Colheita entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Colheita> GetAll()
        {
            throw new NotImplementedException();
        }

        public Colheita GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
