using System.Linq;

namespace Frank.Extensions.MongoDb
{
    public interface IMongoDbContext<TConfig> where TConfig : MongoDbConfigurationBase
    {
        IQueryable<TEntity> Collection<TEntity>(string collectionName = nameof(TEntity));
    }
}
