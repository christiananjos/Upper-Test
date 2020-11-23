using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IBusiness<T> where T : class
    {
        void Cria(T entity);
        void Apaga(T entity);
        void Edita(T entity);
        T RetornaPorId(int id);
        IEnumerable<T> BuscaTodos();
    }
}
