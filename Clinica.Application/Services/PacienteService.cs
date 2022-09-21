using AutoMapper;
using Clinica.Application.Interfaces;
using Clinica.Application.ViewModel;
using Clinica.Domian.Entities;
using Clinica.Domian.Interfaces;

namespace Clinica.Application.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository pacienteRepository;
        private readonly IMapper mapper;
        public PacienteService(IPacienteRepository pacienteRepository, IMapper mapper)
        {
            this.pacienteRepository = pacienteRepository;
            this.mapper = mapper;
        }
        public async Task DeletePacienteAsync(int id)
        {
           await pacienteRepository.DeletePacienteAsync(id);
        }

        public async Task<Paciente> GetPacienteAsync(int id)
        {
            return await pacienteRepository.GetPacienteAsync(id);
        }

        public async Task<IEnumerable<Paciente>> GetPacientesAsync()
        {
            return await pacienteRepository.GetPacientesAsync();
        }

        public async Task<Paciente> InsertPacienteAsync(NovoPacienteViewModel pacienteNovo)
        {
            var paciente = mapper.Map<Paciente>(pacienteNovo);
            return await pacienteRepository.InsertPacienteAsync(paciente);
        }

        public async Task<Paciente> UpdatePacienteAsync(AlteraPacienteViewModel alteraPaciente)
        {
            var paciente = mapper.Map<Paciente>(alteraPaciente);
            return await pacienteRepository.UpdatePacienteAsync(paciente);
        }
    }
}
