using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Extensions.MongoDb
{
    public interface IMongoDbContext<TConfig> where TConfig : MongoDbConfigurationBase
    {
        IQueryable<TEntity> ReadCollection<TEntity>(string collectionName = nameof(TEntity)) where TEntity : IMongoEntity, new();
        Task WriteCollectionAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : IMongoEntity, new();
    }
}
