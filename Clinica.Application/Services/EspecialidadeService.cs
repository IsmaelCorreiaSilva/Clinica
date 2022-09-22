using AutoMapper;
using Clinica.Application.Interfaces;
using Clinica.Application.ViewModel;
using Clinica.Domian.Entities;
using Clinica.Domian.Interfaces;

namespace Clinica.Application.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private readonly IEspecialidadeRepository especialidadeRepository;
        private readonly IMapper mapper;
        public EspecialidadeService(IEspecialidadeRepository especialidadeRepository, IMapper mapper)
        {
            this.especialidadeRepository = especialidadeRepository;
            this.mapper = mapper;
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

        public async Task<Especialidade> InsertEspecialidadeAsync(NovoEspecialidadeViewModel novoEspecialidade)
        {
            var especialidade = mapper.Map<Especialidade>(novoEspecialidade);
            return await especialidadeRepository.InsertEspecialidadeAsync(especialidade);
        }

        public async Task<Especialidade> UpdateEspecialidadeAsync(AlteraEspecialidadeViewModel alteraEspecialidade)
        {
            var especialidade = mapper.Map<Especialidade>(alteraEspecialidade);
            return await especialidadeRepository.UpdateEspecialidadeAsync(especialidade);
        }
    }
}
