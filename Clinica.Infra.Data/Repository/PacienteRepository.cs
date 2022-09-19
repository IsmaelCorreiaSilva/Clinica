using Clinica.Domian.Entities;
using Clinica.Domian.Interfaces;
using Clinica.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Infra.Data.Repository
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly ApplicationDbContext context;

        public PacienteRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task DeletePacienteAsync(int id)
        {
            var pacienteConsultado = await context.Pacientes.FindAsync(id);
            context.Pacientes.Remove(pacienteConsultado);
            await context.SaveChangesAsync();
        }

        public async Task<Paciente> GetPacienteAsync(int id)
        {
            return await context.Pacientes.FindAsync(id);
        }

        public async Task<IEnumerable<Paciente>> GetPacientesAsync()
        {
            return await context.Pacientes.AsNoTracking().ToListAsync();
        }

        public async Task<Paciente> InsertPacienteAsync(Paciente paciente)
        {
            await context.Pacientes.AddAsync(paciente);
            await context.SaveChangesAsync();
            return paciente;
        }

        public async Task<Paciente> UpdatePacienteAsync(Paciente paciente)
        {
            var pacienteConsultado = await context.Pacientes.FindAsync(paciente.Id);
            if (pacienteConsultado == null)
                return null;

            context.Entry(pacienteConsultado).CurrentValues.SetValues(paciente);
            await context.SaveChangesAsync();
            return pacienteConsultado;
        }
    }
}
