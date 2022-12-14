using Clinica.Application.ViewModel;
using FluentValidation;


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
