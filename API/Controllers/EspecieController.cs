using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecieController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<Especie> BuscarTodos()
        {
            var especies = new List<Especie>();

            return especies;
        }

        
        [HttpGet("{id}")]
        public Especie BuscaPorId(int id)
        {
            var especie = new Especie();

            return especie;
        }

       
        [HttpPost]
        public void Gravar([FromBody] Especie especie)
        {
            if (ModelState.IsValid)
            {

            }
        }

       
        [HttpPut("{id}")]
        public void Atualizar([FromBody] Especie especie)
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
