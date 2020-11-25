using Business.Interfaces;
using System;
using System.Collections.Generic;

namespace Business
{
    public class ArvoreBusiness<Arvore> : IBusiness<Arvore> where Arvore : class
    {

        public void Apaga(Arvore entity)
        {
           
        }

        public IEnumerable<Arvore> BuscaTodos()
        {
            throw new NotImplementedException();
        }

        public void Cria(Arvore entity)
        {
            throw new NotImplementedException();
        }

        public void Edita(Arvore entity)
        {
            throw new NotImplementedException();
        }

        public Arvore RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
