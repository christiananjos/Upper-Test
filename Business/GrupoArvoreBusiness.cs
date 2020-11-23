using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class GrupoArvoreBusiness<GrupoArvores> : IBusiness<GrupoArvores> where GrupoArvores : class
    {
        public void Apaga(GrupoArvores entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GrupoArvores> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public void Cria(GrupoArvores entity)
        {
            throw new NotImplementedException();
        }

        public void Edita(GrupoArvores entity)
        {
            throw new NotImplementedException();
        }

        public GrupoArvores RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
