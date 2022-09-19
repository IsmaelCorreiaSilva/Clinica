using Clinica.Domian.Entities;
using Clinica.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Clinica.Domian.Interfaces;

namespace Clinica.Infra.Data.Repository
{
    public class EspecialidadeRepository: IEspecialidadeRepository
    {
        private readonly ApplicationDbContext context;

        public EspecialidadeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Especialidade>> GetEspecialidadesAsync()
        {
            return await context.Especialidades.AsNoTracking().ToListAsync();
        }
        public async Task<Especialidade> GetEspecialidadeAsync(int id)
        {
            //return await context.Especialidades.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id); retorna o primairo encontrado
            //return await context.Especialidades.AsNoTracking().SingleOrDefaultAsync(c => c.Id == id); retorna erro caso encontre mais de um
            return await context.Especialidades.FindAsync(id);
        }
    }
}
