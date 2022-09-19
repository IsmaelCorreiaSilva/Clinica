using Clinica.Application.Interfaces;
using Clinica.Domian.Entities;
using Clinica.Domian.Interfaces;

namespace Clinica.Application.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private readonly IEspecialidadeRepository especialidadeRepository;
        public EspecialidadeService(IEspecialidadeRepository especialidadeRepository)
        {
            this.especialidadeRepository = especialidadeRepository;
        }

        public async Task DeleteEspecialidadeAsync(int id)
        {
            await especialidadeRepository.DeleteEspecialidadeAsync(id);
        }

        public async Task<Especialidade> GetEspecialidadeAsync(int id)
        {
            return await especialidadeRepository.GetEspecialidadeAsync(id);
        }

        public async Task<IEnumerable<Especialidade>> GetEspecialidadesAsync()
        {
            return await especialidadeRepository.GetEspecialidadesAsync();
        }

        public async Task<Especialidade> InsertEspecialidadeAsync(Especialidade especialidade)
        {
            return await especialidadeRepository.InsertEspecialidadeAsync(especialidade);
        }

        public async Task<Especialidade> UpdateEspecialidadeAsync(Especialidade especialidade)
        {
            return await especialidadeRepository.UpdateEspecialidadeAsync(especialidade);
        }
    }
}
