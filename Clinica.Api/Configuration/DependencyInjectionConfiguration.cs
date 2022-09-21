using Clinica.Application.Interfaces;
using Clinica.Application.Services;
using Clinica.Domian.Interfaces;
using Clinica.Infra.Data.Repository;
namespace Clinica.Api.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IPacienteRepository, PacienteRepository>();
            services.AddScoped<IPacienteService, PacienteService>();
            services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();
            services.AddScoped<IEspecialidadeService, EspecialidadeService>();
        }
    }
}