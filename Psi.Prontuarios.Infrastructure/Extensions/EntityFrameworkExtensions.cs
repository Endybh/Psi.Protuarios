using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Psi.Eliane.Infrastructure
{
    public static class EntityFrameworkExtensions
    {
        public static IQueryable<E> AddIncludes<E>(this IQueryable<E> query, params Expression<Func<E,object>>[] includes)
            where E : class
        {
            if(includes != null)
                query = includes.Aggregate(query,(current, include) => current.Include(include));
            
            return query;
        }
    }
}
