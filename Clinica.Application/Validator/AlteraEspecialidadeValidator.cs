using Clinica.Application.ViewModel;
using FluentValidation;

namespace Clinica.Application.Validator
{
    public class AlteraEspecialidadeValidator: AbstractValidator<AlteraEspecialidadeViewModel>
    {
        public AlteraEspecialidadeValidator()
        {
            RuleFor(c => c.Id).NotNull().NotEmpty().GreaterThan(0);
            Include(new NovoEspecialidadeValidator());
        }
    }
}
