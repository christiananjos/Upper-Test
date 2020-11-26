using Business.Interfaces;
using Business.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class ArvoreBusiness<Arvore> : IBusiness<Arvore> where Arvore : class
    {
        private readonly ArvoreRepository<Arvore> _repository;
        private readonly EspecieRepository<Especie> _especieRepository;

        public ArvoreBusiness(ArvoreRepository<Arvore> repository, EspecieRepository<Especie> especieRepository)
        {
            _repository = repository;
            _especieRepository = especieRepository;
        }

        public IEnumerable<Arvore> BuscaTodos()
        {
            try
            {
                var arvores = _repository.GetAll();

                return arvores;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar as arvores \n" + ex.Message);
            }
        }

        public void Cria(Arvore arvore)
        {
            try
            {
                //var idEspecie = arvore.GetType().GetProperty

                
                // var especie = _especieRepository.GetById(arvore.GetType().id)

                _repository.Create(arvore);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao criar um novo registro \n" + ex.Message);
            }
        }

        public void Edita(Arvore arvore)
        {
            try
            {
                _repository.Edit(arvore);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar o registro \n" + ex.Message);
            }
        }

        public Arvore RetornaPorId(int id)
        {
            try
            {
                var arvores = _repository.GetById(id);

                return arvores;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar o registro \n" + ex.Message);
            }
        }

        public void Apaga(Arvore arvore)
        {
            try
            {
                _repository.Delete(arvore);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao remover o registro \n" + ex.Message);
            }
        }
    }
}
