using Clinica.Application.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Validator
{
    public class AlteraPacienteValidator : AbstractValidator<AlteraPacienteViewModel>
    {
        public AlteraPacienteValidator()
        {
            RuleFor(c => c.Id).NotNull().NotEmpty().GreaterThan(0);
            Include(new NovoPacienteValidator());
        }
    }
}
