using Microsoft.EntityFrameworkCore;
using Store.Domian.Entities;

namespace Clinica.Infra.Data.Context
{
    public class ApplicationDbContext
    {
        public DbSet<Produto> Produtos {get; set;}
        public ApplicationDbContext(DbContextOptions options):base(options){

        }
    }
}