using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Libraries.Json
{
    public interface IJsonRepository<TEntity> where TEntity : JsonEntity
    {
        bool PendingChanges { get; }
        string? Folder { get; }

        Task DiscardChangesAsync();

        Task SaveChangesAsync();

        Task<IQueryable<TEntity>> GetAsync();

        Task<TEntity> GetByIdAsync(Guid id);

        Task AddAsync(TEntity entity);

        Task AddAsync(IEnumerable<TEntity> entities);

        Task UpdateAsync(Guid id, TEntity @new);

        Task RemoveAsync(TEntity entity);

        Task RemoveAsync(IEnumerable<TEntity> entities);
    }
}
