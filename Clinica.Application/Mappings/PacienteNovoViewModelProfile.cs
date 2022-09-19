using AutoMapper;
using Clinica.Application.ViewModel;
using Clinica.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Mappings
{
    public class PacienteNovoViewModelProfile : Profile
    {
        public PacienteNovoViewModelProfile()
        {
            CreateMap<PacienteNovoViewModel, Paciente>()
                .ForMember(d => d.Criacao, o => o.MapFrom(x => DateTime.Now))
                .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));
        }
    }
}
