using Clinica.Application.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Validator
{
    public class NovoEspecialidadeValidator:AbstractValidator<NovoEspecialidadeViewModel>
    {
        public NovoEspecialidadeValidator()
        {
            RuleFor(c => c.Nome).NotNull().NotEmpty().MaximumLength(5).MaximumLength(20);
            RuleFor(c => c.Descricao).NotNull().NotEmpty().MinimumLength(10).MaximumLength(100);
        }
    }
}
