using Itsomax.Data.Infrastructure.Models;

namespace Itsomax.Data.Infrastructure.Data
{
    public interface IRepository<T> : IRepositoryWithTypedId<T, long> where T : IEntityWithTypedId<long>
    {
         
    }
}