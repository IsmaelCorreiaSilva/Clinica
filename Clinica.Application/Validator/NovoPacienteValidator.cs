using Clinica.Application.ViewModel;
using FluentValidation;


namespace Clinica.Application.Validator
{
    public class NovoPacienteValidator : AbstractValidator<NovoPacienteViewModel>
    {
        public NovoPacienteValidator()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().MinimumLength(10).MaximumLength(50);
            RuleFor(x => x.DataNascimento).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(x => x.Cpf).NotNull().NotEmpty().MinimumLength(11).MaximumLength(12);
            RuleFor(x => x.Rg).NotNull().NotEmpty().MinimumLength(9).MaximumLength(10);
            RuleFor(x => x.Email).NotNull().NotEmpty().MinimumLength(10).MaximumLength(30);
            RuleFor(x => x.Telefone).NotNull().NotEmpty().Matches("[2-9][0-9]{10}");
            RuleFor(x => x.Sexo).NotNull().NotEmpty().Must(IsMorF).WithMessage("Sexo precisa ser M ou F");
        }

        private bool IsMorF(char sexo)
        {
            return sexo == 'F' || sexo == 'M';
        }
    }
}
