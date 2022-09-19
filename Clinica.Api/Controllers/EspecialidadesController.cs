using Microsoft.AspNetCore.Mvc;
using Clinica.Domian.Entities;
using Clinica.Application.Interfaces;

namespace Clinica.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EspecialidadesController: ControllerBase
    {
        private readonly IEspecialidadeService service;
        public EspecialidadesController(IEspecialidadeService service)
        {
            this.service = service;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id){
            return Ok(await service.GetEspecialidadeAsync(id));
        }
        [HttpGet]
        public async Task<ActionResult> Get(){
            return Ok(await service.GetEspecialidadesAsync());
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