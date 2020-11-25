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
    public class GrupoArvoreController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<string> BuscarTodosGrupos()
        {
            return new string[] { "value1", "value2" };
        }

        
        [HttpGet("{id}")]
        public string BuscaPorId(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public void GravarGrupo([FromBody] string value)
        {
            if (ModelState.IsValid)
            {

            }
        }

        [HttpPut]
        public void Atualizar(int id, [FromBody] string value)
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
