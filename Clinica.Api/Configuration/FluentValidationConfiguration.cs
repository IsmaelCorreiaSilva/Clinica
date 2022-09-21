
namespace Clinica.Api.Configuration
{
    public static class FluentValidationConfiguration
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {

            //services.AddControllers().AddFluentValidation(fv =>
            //{
            //    fv.RegisterValidatorsFromAssemblyContaining<ProdutoValidator>();
            //    fv.RegisterValidatorsFromAssemblyContaining<ProdutoBaseValidator>();
            //    fv.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
            //});
        }
    }
}