using LiteDB;
using Microsoft.Extensions.Options;
using Namotion.Reflection;

namespace Frank.Libraries.DataStorage.LiteDb;

public class LiteDbDataContext : IDisposable
{
    private readonly IOptions<LiteDbConnection> _options;
    private readonly ILiteDatabase _liteDatabase;

    public LiteDbDataContext(IOptions<LiteDbConnection> options)
    {
        _options = options;

        var directory = new FileInfo(_options.Value.LiteDbDataFile).Directory;

        if (directory != null && !directory.Exists)
            directory.Create();

        _liteDatabase = new LiteDatabase(_options.Value.LiteDbDataFile);
    }

    public ILiteCollection<T> GetCollection<T>() where T : class, IKeyed, new() => _liteDatabase.GetCollection<T>(typeof(T).GetDisplayName(), BsonAutoId.Guid);

    public void Dispose() => _liteDatabase.Dispose();
}