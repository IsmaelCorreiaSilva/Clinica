using Microsoft.AspNetCore.Mvc;
using Clinica.Domian.Entities;
using Clinica.Application.Interfaces;
using Clinica.Application.ViewModel;
using FluentValidation;

namespace Clinica.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EspecialidadesController : ControllerBase
    {
        private readonly IEspecialidadeService especialidadeService;
        private readonly IValidator<NovoEspecialidadeViewModel> validatorNovo;
        private readonly IValidator<AlteraEspecialidadeViewModel> validatorAltera;
        public EspecialidadesController(IEspecialidadeService especialidadeService,
            IValidator<NovoEspecialidadeViewModel> validatorNovo, IValidator<AlteraEspecialidadeViewModel> validatorAltera)
        {
            this.especialidadeService = especialidadeService;
            this.validatorNovo = validatorNovo;
            this.validatorAltera = validatorAltera;
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
        public async Task<ActionResult> Post(NovoEspecialidadeViewModel novoEspecialidade)
        {
            var validacao = await validatorNovo.ValidateAsync(novoEspecialidade);
            if (validacao.IsValid)
            {
                var especialidadeInserida = await especialidadeService.InsertEspecialidadeAsync(novoEspecialidade);
                return CreatedAtAction(nameof(Get), new { id = especialidadeInserida.Id }, especialidadeInserida);
            }
            else
            {
                return BadRequest(validacao.ToString());
            }
        }
        [HttpPut]
        public async Task<ActionResult> Put(AlteraEspecialidadeViewModel alteraEspecialidade)
        {
            var validacao = await validatorAltera.ValidateAsync(alteraEspecialidade);
            if (validacao.IsValid)
            {

                var especialidadeAtualizada = await especialidadeService.UpdateEspecialidadeAsync(alteraEspecialidade);
                if (especialidadeAtualizada == null)
                {
                    return NotFound();
                }
                return Ok(especialidadeAtualizada);
            }
            else
            {
                return BadRequest(validacao.ToString());
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await especialidadeService.DeleteEspecialidadeAsync(id);
            return NoContent();
        }

    }
}