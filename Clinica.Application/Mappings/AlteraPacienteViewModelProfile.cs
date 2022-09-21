using AutoMapper;
using Clinica.Application.ViewModel;
using Clinica.Domian.Entities;

namespace Clinica.Application.Mappings
{
    public class AlteraPacienteViewModelProfile : Profile
    {
        public AlteraPacienteViewModelProfile()
        { 
            CreateMap<AlteraPacienteViewModel, Paciente>()
                    .ForMember(d => d.UltimaAtualiacao, o => o.MapFrom(x => DateTime.Now))
                    .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));
        }
    }
}
