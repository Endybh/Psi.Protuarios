using System.Linq.Expressions;
using Psi.Eliane.Core.Domain.Entities;

namespace Psi.Prontuarios.Core;

public interface IRepositorio<Entidade> where Entidade : BaseEntity
{
    Task<Entidade> InsertAsync(Entidade entitie);
    Task UpdateAsync(Entidade entitie);
    Task<List<Entidade>> SelectAsync(Expression<Func<Entidade, bool>> predicate);
    Task<List<Entidade>> SelectAsync(Expression<Func<Entidade, bool>> predicate, params Expression<Func<Entidade, object>>[] includes);
    Task<Entidade> GetAsync(int id);
    Task DeleteAsync(Entidade entitie);
}
