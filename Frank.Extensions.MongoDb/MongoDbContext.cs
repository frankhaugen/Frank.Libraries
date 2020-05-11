using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Frank.Extensions.MongoDb
{
    public class MongoDbContext<TConfig> : IMongoDbContext<TConfig> where TConfig : MongoDbConfigurationBase, new()
    {
        private readonly IMongoDatabase _mongoDatabase;

        public MongoDbContext(IOptions<TConfig> options)
        {
            var mongoClient = new MongoClient(MongoClientSettings.FromConnectionString(options.Value.ConnectionString));
            _mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);
        }

        public IMongoCollection<T> Collection<T>() => _mongoDatabase.GetCollection<T>(typeof(T).Name.ToLowerInvariant() + "s");
    }
}