using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Repositories
{
    public class ArvoreRepository<Arvore> : IRepository<Arvore> where Arvore : class
    {
        public void Create(Arvore entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Arvore entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Arvore entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Arvore> GetAll()
        {
            throw new NotImplementedException();
        }

        public Arvore GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
