using Business.Interfaces;
using System;
using System.Collections.Generic;

namespace Business
{
    public class EspecieBusiness<Especie> : IBusiness<Especie> where Especie : class
    {
        public void Apaga(Especie entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Especie> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public void Cria(Especie entity)
        {
            throw new NotImplementedException();
        }

        public void Edita(Especie entity)
        {
            throw new NotImplementedException();
        }

        public Especie RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
