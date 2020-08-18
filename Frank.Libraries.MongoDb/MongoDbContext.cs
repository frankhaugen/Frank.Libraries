using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Frank.Libraries.MongoDb
{
    public class MongoDbContext<TConfig> : IMongoDbContext where TConfig : MongoDbConfigurationBase, new()
    {
        private readonly IMongoDatabase _mongoDatabase;

        public MongoDbContext(IOptions<TConfig> options)
        {
            var mongoClient = new MongoClient(MongoClientSettings.FromConnectionString(options.Value.ConnectionString));
            _mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);
        }

        public IMongoCollection<T> Collection<T>()
        {
            return _mongoDatabase.GetCollection<T>(GetAttributeCollectionName<T>() + "s");
        }

        private string GetAttributeCollectionName<T>()
        {
            return (typeof(T).GetTypeInfo().GetCustomAttributes(typeof(CollectionName)).FirstOrDefault() as CollectionName)?.Name ?? typeof(T).Name.ToLowerInvariant();
        }
    }
}