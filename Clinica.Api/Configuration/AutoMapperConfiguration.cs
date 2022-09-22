

using Clinica.Application.ViewModel;

namespace  Clinica.Api.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(NovoPacienteViewModel), 
                typeof(AlteraPacienteViewModel),
                typeof(NovoEspecialidadeViewModel),
                typeof(AlteraEspecialidadeViewModel)
            );
        }
    }
}