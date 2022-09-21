using AutoMapper;
using Clinica.Application.ViewModel;
using Clinica.Domian.Entities;

namespace Clinica.Application.Mappings
{
    public class NovoPacienteViewModelProfile : Profile
    {
        public NovoPacienteViewModelProfile()
        {
            CreateMap<NovoPacienteViewModel, Paciente>()
                .ForMember(d => d.Criacao, o => o.MapFrom(x => DateTime.Now))
                .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));
        }
    }
}
