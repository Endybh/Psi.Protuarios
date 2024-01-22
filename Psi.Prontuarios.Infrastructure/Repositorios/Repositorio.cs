using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Psi.Eliane.Core.Domain.Entities;
using Psi.Eliane.Infrastructure;
using Psi.Prontuarios.Core;

namespace Psi.Prontuarios.Infrastructure;

public abstract class Repositorio<Entidade> : IRepositorio<Entidade> where Entidade : BaseEntity
{
     private readonly PsiContext _context;

        public Repositorio(PsiContext context)
        {
            _context = context;
        }
        public virtual async Task DeleteAsync(Entidade entitie)
        {
            _context.Set<Entidade>().Remove(entitie);
        }

        public virtual async Task<Entidade> GetAsync(int id) => await _context.FindAsync<Entidade>(new { Id = id });        

        public virtual async Task<Entidade> InsertAsync(Entidade entitie)
        {
            await _context.Set<Entidade>().AddAsync(entitie);
            return entitie;
        }

        public virtual async Task<List<Entidade>> SelectAsync(Expression<Func<Entidade, bool>> predicate)
        {
            return await _context.Set<Entidade>().Where(predicate).ToListAsync();
        }

        public virtual async Task<List<Entidade>> SelectAsync(Expression<Func<Entidade, bool>> predicate, params Expression<Func<Entidade, object>>[] includes)
        {
            return await _context.Set<Entidade>().AddIncludes(includes).Where(predicate).ToListAsync();
        }

        public virtual async Task UpdateAsync(Entidade entitie)
        {
           _context.Entry(entitie).State = EntityState.Modified;
        }
}
