using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoArvoreController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<GrupoArvores> BuscarTodos()
        {
            var grupos = new List<GrupoArvores>();

            return grupos;
        }

        
        [HttpGet("{id}")]
        public GrupoArvores BuscaPorId(int id)
        {
            var grupo = new GrupoArvores();


            return grupo;
        }

        
        [HttpPost]
        public void Gravar([FromBody] GrupoArvores grupo)
        {
            if (ModelState.IsValid)
            {

            }
        }

        [HttpPut]
        public void Atualizar([FromBody] GrupoArvores grupo)
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
