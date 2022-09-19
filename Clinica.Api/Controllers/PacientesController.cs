using Clinica.Application.Interfaces;
using Clinica.Application.ViewModel;
using Clinica.Domian.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly IPacienteService pacienteService;
        private readonly IValidator<PacienteNovoViewModel> validator;
        public PacientesController(IPacienteService pacienteService, IValidator<PacienteNovoViewModel> validator)
        {
            this.pacienteService = pacienteService;
            this.validator = validator;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await pacienteService.GetPacientesAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await pacienteService.GetPacienteAsync(id));
        }
        [HttpPost]
        public async Task<ActionResult> Post(PacienteNovoViewModel novoPaciente)
        {
            var pacienteInserido = await pacienteService.InsertPacienteAsync(novoPaciente);
            return CreatedAtAction(nameof(Get), new { id = pacienteInserido.Id }, pacienteInserido);
            //var validacao = await validator.ValidateAsync(novoPaciente);
            //if (validacao.IsValid)
            //{ 
            //    var pacienteInserido = await pacienteService.InsertPacienteAsync(novoPaciente);
            //    return CreatedAtAction(nameof(Get), new { id = pacienteInserido.Id }, pacienteInserido);
            //}
            //else
            //{
            //    return BadRequest(validacao.ToString());
            //}
        }
        [HttpPut]
        public async Task<ActionResult> Put(Paciente paciente)
        {
            var pacienteAtualizado = await pacienteService.UpdatePacienteAsync(paciente);
            if (pacienteAtualizado == null)
                return NotFound();

            return Ok(pacienteAtualizado);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await pacienteService.DeletePacienteAsync(id);
            return NoContent();
        }

    }
}