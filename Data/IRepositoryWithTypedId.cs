using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Itsomax.Data.Infrastructure.Models;
using System.Threading.Tasks;

namespace Itsomax.Data.Infrastructure.Data
{
    public interface IRepositoryWithTypedId<T, in TId> where T : IEntityWithTypedId<TId>
    {
        IQueryable<T> Query();

        T GetById(long id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
            
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        
        void SaveChanges();
        Task SaveChangesAsync();

        
    }
}