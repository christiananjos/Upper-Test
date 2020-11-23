using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ColheitaBusiness<Colheita> : IBusiness<Colheita> where Colheita : class
    {
        public void Apaga(Colheita entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Colheita> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public void Cria(Colheita entity)
        {
            throw new NotImplementedException();
        }

        public void Edita(Colheita entity)
        {
            throw new NotImplementedException();
        }

        public Colheita RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
