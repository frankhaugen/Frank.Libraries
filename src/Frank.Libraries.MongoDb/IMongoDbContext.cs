using MongoDB.Driver;

namespace Frank.Libraries.MongoDb
{
    public interface IMongoDbContext
    {
        IMongoCollection<T> Collection<T>();
    }
}