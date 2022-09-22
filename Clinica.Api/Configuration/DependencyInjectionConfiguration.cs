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
            //Repositories
            services.AddScoped<IPacienteRepository, PacienteRepository>();
            services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();

            //Services
            services.AddScoped<IPacienteService, PacienteService>();
            services.AddScoped<IEspecialidadeService, EspecialidadeService>();


            //Fluent Validation
            services.AddScoped<IValidator<AlteraPacienteViewModel>, AlteraPacienteValidator>();
            services.AddScoped<IValidator<NovoPacienteViewModel>, NovoPacienteValidator>();
            services.AddScoped<IValidator<AlteraEspecialidadeViewModel>, AlteraEspecialidadeValidator>();
            services.AddScoped<IValidator<NovoEspecialidadeViewModel>, NovoEspecialidadeValidator>();

        }
    }
}