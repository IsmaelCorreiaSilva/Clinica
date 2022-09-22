using AutoMapper;
using Clinica.Application.ViewModel;
using Clinica.Domian.Entities;


namespace Clinica.Application.Mappings
{
    public class AlteraEspecialidadeViewModelProfile:Profile
    {
        public AlteraEspecialidadeViewModelProfile()
        {
            CreateMap<AlteraEspecialidadeViewModel, Especialidade>();
        }
    }
}
