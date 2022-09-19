using Clinica.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domian.Interfaces
{
    public interface IEspecialidadeRepository
    {
        Task<IEnumerable<Especialidade>> GetEspecialidadesAsync();
        Task<Especialidade> GetEspecialidadeAsync(int id);
        Task<Especialidade> InsertEspecialidadeAsync(Especialidade  especialidade);
        Task<Especialidade> UpdateEspecialidadeAsync(Especialidade especialidade);
        Task DeleteEspecialidadeAsync(int id);
    }
}
