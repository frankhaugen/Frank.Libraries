using MongoDB.Driver;

namespace Frank.Extensions.MongoDb
{
    public interface IMongoDbContext<TConfig> where TConfig : MongoDbConfigurationBase
    {
        IMongoCollection<T> Collection<T>();
    }
}
