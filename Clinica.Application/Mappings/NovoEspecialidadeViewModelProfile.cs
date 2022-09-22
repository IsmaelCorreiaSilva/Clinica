using AutoMapper;
using Clinica.Application.ViewModel;
using Clinica.Domian.Entities;

namespace Clinica.Application.Mappings
{
    public class NovoEspecialidadeViewModelProfile:Profile
    {
        public NovoEspecialidadeViewModelProfile()
        {
            CreateMap<NovoEspecialidadeViewModel, Especialidade>();
        }
    }
}
