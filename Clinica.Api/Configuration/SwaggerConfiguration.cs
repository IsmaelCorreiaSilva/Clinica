using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Clinica.Api.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Clinica",
                        Version = "v1",
                        Description = "API para Clinica",
                        Contact = new OpenApiContact
                        {
                            Name = "Ismael C. da Silva",
                            Email = "ismael.correia2013@mail.com",
                            Url = new Uri("https://github.com/IsmaelCorreiaSilva")
                        },
                        License = new OpenApiLicense
                        {
                            Name = "OSD",
                            Url = new Uri("https://opensource.org/osd")
                        }
                    }
                )
            );
        }
        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "Store v1");
            });
        }
    }
}