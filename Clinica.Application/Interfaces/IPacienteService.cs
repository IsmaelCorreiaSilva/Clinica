using Clinica.Application.ViewModel;
using Clinica.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IPacienteService
    {
        Task<IEnumerable<Paciente>> GetPacientesAsync();
        Task<Paciente> GetPacienteAsync(int id);
        Task<Paciente> InsertPacienteAsync(PacienteNovoViewModel paciente);
        Task<Paciente> UpdatePacienteAsync(Paciente paciente);
        Task DeletePacienteAsync(int id);
    }
}
