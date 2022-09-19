using Microsoft.AspNetCore.Mvc;
using Clinica.Domian.Entities;
using Clinica.Application.Interfaces;

namespace Clinica.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EspecialidadesController: ControllerBase
    {
        private readonly IEspecialidadeService especialidadeService;
        public EspecialidadesController(IEspecialidadeService especialidadeService)
        {
            this.especialidadeService = especialidadeService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await especialidadeService.GetEspecialidadeAsync(id));
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await especialidadeService.GetEspecialidadesAsync());
        }
        [HttpPost]
        public async Task<ActionResult> Post(Especialidade especialidade)
        {
            var especialidadeInserida = await especialidadeService.InsertEspecialidadeAsync(especialidade);
            return CreatedAtAction(nameof(Get), new { id = especialidade.Id }, especialidade);
        }
        [HttpPut]
        public async Task<ActionResult>  Put(Especialidade especialidade)
        {
            var especialidadeAtualizada = await especialidadeService.UpdateEspecialidadeAsync(especialidade);
            if(especialidadeAtualizada == null)
            {
                return NotFound();
            }
            return Ok(especialidadeAtualizada);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await especialidadeService.DeleteEspecialidadeAsync(id);
            return NoContent();
        }

    }
}