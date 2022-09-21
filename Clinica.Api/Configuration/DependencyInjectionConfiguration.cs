using Clinica.Application.Interfaces;
using Clinica.Application.Services;
using Clinica.Application.Validator;
using Clinica.Application.ViewModel;
using Clinica.Domian.Interfaces;
using Clinica.Infra.Data.Repository;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

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
            services.AddScoped<IValidator<AlteraPacienteViewModel>, AlteraPacienteValidator>();
            services.AddScoped<IValidator<NovoPacienteViewModel>, NovoPacienteValidator>();

        }
    }
}