using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Delete(T entity);
        void Edit(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void SaveChanges();
    }
}
