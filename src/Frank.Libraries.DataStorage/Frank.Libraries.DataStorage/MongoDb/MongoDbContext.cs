using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Namotion.Reflection;

namespace Frank.Libraries.DataStorage.MongoDb;

public class MongoDbContext
{
    private readonly IMongoClient _client;
    private readonly IOptions<MongoDbConnection> _options;

    public MongoDbContext(IOptions<MongoDbConnection> options)
    {
        _options = options;
        _client = new MongoClient(_options.Value.ConnectionString);
    }

    public IMongoCollection<T> GetCollection<T>() where T : class, IKeyed, new()
        => _client.GetDatabase(_options.Value.DatabaseName)
                  .GetCollection<T>(typeof(T).GetDisplayName());
}