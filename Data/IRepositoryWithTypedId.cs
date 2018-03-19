using System.Linq;
using Microsoft.EntityFrameworkCore.Storage;
using Itsomax.Data.Infrastructure.Models;
using System.Threading.Tasks;

namespace Itsomax.Data.Infrastructure.Data
{
    public interface IRepositoryWithTypedId<T, in TId> where T : IEntityWithTypedId<TId>
    {
        IQueryable<T> Query();

        void Add(T entity);

        IDbContextTransaction BeginTransaction();

        void SaveChanges();
        Task SaveChangesAsync();

        void Remove(T entity);
    }
}