using Microsoft.Extensions.Options;
using Namotion.Reflection;

namespace Frank.Libraries.DataStorage.Json;

public class JsonContext
{
    private readonly DirectoryInfo _directoryInfo;

    public JsonContext(IOptions<JsonConnection> options)
    {
        _directoryInfo = new DirectoryInfo(options.Value.JsonDataFolder);
        _directoryInfo.Create();
    }

    public JsonTable<T> GetTable<T>() where T : class, IKeyed, new() => new(EnsureDirectoryExists<T>());

    private string EnsureDirectoryExists<T>()
    {
        var directoryPath = Path.Combine(_directoryInfo.FullName, typeof(T).GetDisplayName());
        var directoryInfo = new DirectoryInfo(directoryPath);
        directoryInfo.Create();
        return directoryPath;
    }
}