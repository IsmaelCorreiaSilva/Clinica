using Clinica.Application.Interfaces;
using Clinica.Domian.Entities;
using Clinica.Domian.Interfaces;

namespace Clinica.Application.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private readonly IEspecialidadeRepository repository;
        public EspecialidadeService(IEspecialidadeRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Especialidade> GetEspecialidadeAsync(int id)
        {
            return await repository.GetEspecialidadeAsync(id);
        }

        public async Task<IEnumerable<Especialidade>> GetEspecialidadesAsync()
        {
            return await repository.GetEspecialidadesAsync();
        }
    }
}
