using Business.Interfaces;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Repositories
{
    public class ColheitaRepository<Colheita> : IRepository<Colheita> where Colheita : class
    {
        private readonly DataContext _context;

        public ColheitaRepository(DataContext context) => _context = context;

        public void Create(Colheita entity)
        {
            _context.Set<Colheita>().Add(entity);
        }

        public void Delete(Colheita entity)
        {
            _context.Set<Colheita>().Remove(entity);
        }

        public void Edit(Colheita entity)
        {
            _context.Set<Colheita>().Update(entity);
        }

        public IEnumerable<Colheita> GetAll()
        {
            return _context.Set<Colheita>();
        }

        public Colheita GetById(int id)
        {
            return (Colheita)_context.Colheitas.Select(x => x.IdColheita == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
