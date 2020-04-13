using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Extensions.MongoDb
{
    public interface IMongoDbRepository<TEntity, TConfig> where TEntity : IMongoEntity, new() where TConfig : MongoDbConfigurationBase, new()
    {
        bool PendingChanges { get; }
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
