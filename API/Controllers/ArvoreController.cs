using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Mvc;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArvoreController : ControllerBase
    {
        private readonly ArvoreBusiness<Arvore> _business;

        public ArvoreController(ArvoreBusiness<Arvore> business)
        {
            _business = business;
        }

        [HttpGet]
        public IEnumerable<Arvore> BuscarTodos()
        {
            var arvores = new List<Arvore>();

            return arvores;
        }

        
        [HttpGet("{id}")]
        public Arvore BuscaPorId(int id)
        {
            var arvore = new Arvore();

            return arvore;
        }

        
        [HttpPost]
        public void Gravar([FromBody] Arvore arvore)
        {
            if (ModelState.IsValid)
            {
                _business.Cria(arvore);
            }
        }

        
        [HttpPut("{id}")]
        public void Atualizar([FromBody] Arvore arvore)
        {
            if (ModelState.IsValid)
            {

            }
        }

        
        [HttpDelete("{id}")]
        public void Remover(int id)
        {
        }
    }
}
