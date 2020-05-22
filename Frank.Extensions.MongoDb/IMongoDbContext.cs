using MongoDB.Driver;

namespace Frank.Extensions.MongoDb
{
    public interface IMongoDbContext
    {
        IMongoCollection<T> Collection<T>();
    }
}