using Clinica.Api.Configuration;
using Clinica.Application.Interfaces;
using Clinica.Application.Mappings;
using Clinica.Application.Services;
using Clinica.Application.Validator;
using Clinica.Application.ViewModel;
using Clinica.Domian.Interfaces;
using Clinica.Infra.Data.Context;
using Clinica.Infra.Data.Repository;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddScoped<IValidator<PacienteNovoViewModel>, PacienteNovoValidator>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionClinica")));
builder.Services.AddDependencyInjectionConfiguration();
//builder.Services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();
//builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
//builder.Services.AddScoped<IEspecialidadeService, EspecialidadeService>();
//.Services.AddScoped<IPacienteService, PacienteService>();
//builder.Services.AddAutoMapper(typeof(NovoPacienteViewModelProfile));
builder.Services.AddAutoMapperConfiguration();
builder.Services.AddSwaggerGen();
//.Services.AddSwaggerConfiguration();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwaggerConfiguration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
