using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Extensions.Json
{
    public interface IJsonRepository<TEntity> where TEntity : class
    {
        bool PendingChanges { get; }
        string? Folder { get; }
        Task DiscardChangesAsync();
        Task SaveChangesAsync();
        Task<IQueryable<TEntity>> GetAsync();
        Task AddAsync(TEntity entity);
        Task AddAsync(IEnumerable<TEntity> entities);
        Task UpdateAsync(TEntity original, TEntity @new);
        Task RemoveAsync(TEntity entity);
        Task RemoveAsync(IEnumerable<TEntity> entities);
    }
}