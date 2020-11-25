using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColheitaController : ControllerBase
    {
        // GET: api/<ColheitaController>
        // GET: api/<ArvoreController>
        [HttpGet]
        public IEnumerable<Colheita> BuscarTodos()
        {
            var colheitas = new List<Colheita>();

            return colheitas;
        }

        // GET api/<ArvoreController>/5
        [HttpGet("{id}")]
        public Colheita BuscaPorId(int id)
        {
            var colheita = new Colheita();

            return colheita;
        }

        // POST api/<ArvoreController>
        [HttpPost]
        public void Gravar([FromBody] Colheita colheita)
        {
            if (ModelState.IsValid)
            {

            }
        }

        // PUT api/<ArvoreController>/5
        [HttpPut("{id}")]
        public void Atualizar([FromBody] Colheita colheita)
        {
            if (ModelState.IsValid)
            {

            }
        }

        // DELETE api/<ArvoreController>/5
        [HttpDelete("{id}")]
        public void Remover(int id)
        {
        }
    }
}
