using Business.Interfaces;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Repositories
{
    public class EspecieRepository<Especie> : IRepository<Especie> where Especie : class
    {
        private readonly DataContext _context;

        public EspecieRepository(DataContext context) => _context = context;

        public void Create(Especie entity)
        {
            _context.Set<Especie>().Add(entity);
        }

        public void Delete(Especie entity)
        {
            _context.Set<Especie>().Remove(entity);
        }

        public void Edit(Especie entity)
        {
            _context.Set<Especie>().Update(entity);
        }

        public IEnumerable<Especie> GetAll()
        {
            return _context.Set<Especie>();
        }

        public Especie GetById(int id)
        {
            return (Especie)_context.Especies.Select(x => x.IdEspecie == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
