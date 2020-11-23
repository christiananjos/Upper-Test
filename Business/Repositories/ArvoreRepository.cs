using Business.Interfaces;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Repositories
{
    public class ArvoreRepository<Arvore> : IRepository<Arvore> where Arvore : class
    {
        private readonly DataContext _context;

        public ArvoreRepository(DataContext context) => _context = context;

        public void Create(Arvore entity)
        {
            _context.Set<Arvore>().Add(entity);
        }

        public void Delete(Arvore entity)
        {
            _context.Set<Arvore>().Remove(entity);
        }

        public void Edit(Arvore entity)
        {
            _context.Set<Arvore>().Update(entity);
        }

        public IEnumerable<Arvore> GetAll()
        {
            return _context.Set<Arvore>();
        }

        public Arvore GetById(int id)
        {
            return (Arvore)_context.Arvores.Select(x => x.IdArvore == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
