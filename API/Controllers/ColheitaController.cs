using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<string> BuscarTodos()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ArvoreController>/5
        [HttpGet("{id}")]
        public string BuscaPorId(int id)
        {
            return "value";
        }

        // POST api/<ArvoreController>
        [HttpPost]
        public void Gravar([FromBody] string value)
        {
            if (ModelState.IsValid)
            {

            }
        }

        // PUT api/<ArvoreController>/5
        [HttpPut("{id}")]
        public void Atualizar(int id, [FromBody] string value)
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
