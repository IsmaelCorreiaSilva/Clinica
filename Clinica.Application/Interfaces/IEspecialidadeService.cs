using Clinica.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Interfaces
{
    public interface IEspecialidadeService
    {
        Task<IEnumerable<Especialidade>> GetEspecialidadesAsync();
        Task<Especialidade> GetEspecialidadeAsync(int id);
    }
}
