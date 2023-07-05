using Frank.Libraries.DataStorage.Abstractions;
using Frank.Libraries.Json;
using Microsoft.Extensions.Options;
using Namotion.Reflection;

namespace Frank.Libraries.DataStorage.Json;

public class JsonDirectory<T> : IJsonDirectory<T> where T : class, IEntity
{
    private readonly DirectoryInfo _directory;
    private readonly IJsonSerializer _jsonSerializer;
    private readonly IOptions<JsonConfiguration> _options;

    public JsonDirectory(IOptions<JsonConfiguration> options, IJsonSerializer jsonSerializer)
    {
        _options = options;
        _jsonSerializer = jsonSerializer;
        _directory = new DirectoryInfo(GetDirectoryPath());
        EnsureDirectoryExists();
    }

    public async Task SaveAsync(T entity)
    {
        var file = GetOrCreateFile(entity.Id);
        await using var stream = file.OpenWrite();
        var json = _jsonSerializer.SerializeToUtf8Bytes(entity);
        var lastByteIndex = Array.FindLastIndex(json.ToArray(), b => b != 0) + 1;
        await stream.WriteAsync(json[..lastByteIndex]);
    }

    public async Task SaveAsync(IEnumerable<T> entities)
    {
        foreach (var entity in entities)
        {
            await SaveAsync(entity);
        }
    }

    public async Task<T?> LoadAsync(Guid id)
    {
        var file = GetOrCreateFile(id);
        var entity = await ReadAndDeserializeAsync(file);
        return entity;
    }

    public async IAsyncEnumerable<T> LoadAsync()
    {
        var files = _directory.EnumerateFiles("*.json", SearchOption.TopDirectoryOnly);
        foreach (var file in files)
        {
            var entity = await ReadAndDeserializeAsync(file);
            if (entity != null)
                yield return entity;
        }
    }

    public async Task RemoveAsync(Guid entityId)
    {
        var filePath = GetFilePath(entityId);
        var file = new FileInfo(filePath);
        if (file.Exists)
            await Task.Run(() => file.Delete());
    }

    private async Task<T?> ReadAndDeserializeAsync(FileInfo file)
    {
        using var stream = file.OpenText();
        var json = await stream.ReadToEndAsync();
        return _jsonSerializer.Deserialize<T>(json);
    }

    private FileInfo GetOrCreateFile(Guid id)
    {
        EnsureDirectoryExists();
        var filePath = GetFilePath(id);
        var file = new FileInfo(filePath);
        if (!file.Directory!.Exists) file.Directory.Create();
        if (!file.Exists) file.Create().Close();
        return file;
    }

    private void EnsureDirectoryExists()
    {
        if (!_directory.Exists)
            _directory.Create();
    }

    private string GetDirectoryPath() => Path.Combine(_options.Value.Folder, $"{typeof(T).GetDisplayName()}");

    private string GetFilePath(Guid entity) => Path.Combine(_directory.FullName, GetFileName(entity));

    private static string GetFileName(Guid id) => $"{id.ToString()}.json";
}