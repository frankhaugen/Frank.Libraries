using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public IQueryable<TEntity> ReadCollection<TEntity>(string collectionName = nameof(TEntity)) where TEntity : IMongoEntity, new()
        {
            var name = typeof(TEntity).Name.ToLowerInvariant();
            return _mongoDatabase.GetCollection<TEntity>(name).AsQueryable();
        }

        public async Task WriteCollectionAsync<TEntity>(IEnumerable<TEntity> entities) where TEntity : IMongoEntity, new()
        {
            var name = typeof(TEntity).Name.ToLowerInvariant();
            //_mongoDatabase.GetCollection<TEntity>(name).DeleteMany(FilterDefinition<TEntity>.Empty);
            //var writeModels = entities.Select(x => new InsertOneModel<TEntity>(x));
            var writeModels = entities.Select(x => x.ToBsonDocument());
        }
    }
}
