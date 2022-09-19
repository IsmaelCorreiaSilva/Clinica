using Microsoft.EntityFrameworkCore;
using Clinica.Domian.Entities;

namespace Clinica.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Especialidade> Especialidades {get; set;}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}