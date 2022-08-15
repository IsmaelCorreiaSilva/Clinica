using Microsoft.AspNetCore.Mvc;
using Clinica.Domian.Entities;

namespace Clinica.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EspecialidadeController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok(
                new List<Especialidade>(){
                    new Especialidade{
                        Id = 1,
                        Nome = "Cardiológia",
                        Descricao = "Especialidade associada a doenças cardiacas"
                    },
                    new Especialidade{
                        Id = 1,
                        Nome = "Dermatogolia",
                        Descricao = "Especialidade associada a doenças da pele"
                    }
                }
            );
        }
        [HttpGet("{id}")]
        public string GetAll(){
            return "ValueTask";
        }
        [HttpPost]
        public void Post([FromBody] string dados){

        }
        [HttpPut("{id}")]
        public void Put(){

        }
        [HttpDelete("{id}")]
        public void Delete(){

        }

    }
}