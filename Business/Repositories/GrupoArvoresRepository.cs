using Business.Interfaces;
using Data;
using System.Collections.Generic;
using System.Linq;

namespace Business.Repositories
{
    public class GrupoArvoresRepository<GrupoArvores> : IRepository<GrupoArvores> where GrupoArvores : class
    {
		private readonly DataContext _context;

		public GrupoArvoresRepository(DataContext context) => _context = context;

		public void Create(GrupoArvores entity)
		{
			_context.Set<GrupoArvores>().Add(entity);
		}

		public void Delete(GrupoArvores entity)
		{
			_context.Set<GrupoArvores>().Remove(entity);
		}

		public void Edit(GrupoArvores entity)
		{
			_context.Set<GrupoArvores>().Update(entity);
		}

		public IEnumerable<GrupoArvores> GetAll()
		{
			return _context.Set<GrupoArvores>();
		}

		public GrupoArvores GetById(int id)
		{
			return (GrupoArvores)_context.GrupoArvores.Select(x => x.IdGrupoArvores == id);
		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}
	}
}
