using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Linq;

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

        public MongoDbContext(TConfig options)
        {
            var mongoClient = new MongoClient(MongoClientSettings.FromConnectionString(options.ConnectionString));
            _mongoDatabase = mongoClient.GetDatabase(options.DatabaseName);
        }

        public IQueryable<TEntity> Collection<TEntity>(string collectionName = nameof(TEntity))
        {
            var name = typeof(TEntity).Name.ToLowerInvariant();
            return _mongoDatabase.GetCollection<TEntity>(name).AsQueryable();
        }
    }
}
