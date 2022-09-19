using Clinica.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domian.Interfaces
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> GetPacientesAsync();
        Task<Paciente> GetPacienteAsync(int id);
        Task<Paciente> InsertPacienteAsync(Paciente paciente);
        Task<Paciente> UpdatePacienteAsync(Paciente paciente);
        Task DeletePacienteAsync(int id);

    }
}
