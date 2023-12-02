using System.Text.Json;

namespace Frank.Libraries.DataStorage.Json;

public class JsonTable<T> where T : class, new()
{
    private readonly string _folderPath;
    private readonly ReaderWriterLockSlim _lockSlim = new();

    public JsonTable(string folderPath) => _folderPath = folderPath;

    public T? Get(Guid id)
    {
        _lockSlim.EnterReadLock();
        try
        {
            var filePath = GetFilePath(_folderPath, id);
            if (!File.Exists(filePath))
            {
                return null;
            }

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(json);
        }
        finally
        {
            _lockSlim.ExitReadLock();
        }
    }

    public void Save(Guid id, T entity)
    {
        _lockSlim.EnterWriteLock();
        try
        {
            var filePath = GetFilePath(_folderPath, id);
            var json = JsonSerializer.Serialize(entity);
            File.WriteAllText(filePath, json);
        }
        finally
        {
            _lockSlim.ExitWriteLock();
        }
    }

    public IEnumerable<T?> GetAll()
    {
        _lockSlim.EnterReadLock();
        try
        {
            foreach (var filePath in Directory.EnumerateFiles(_folderPath))
            {
                var json = File.ReadAllText(filePath);
                yield return JsonSerializer.Deserialize<T>(json);
            }
        }
        finally
        {
            _lockSlim.ExitReadLock();
        }
    }

    public void Delete(Guid id)
    {
        _lockSlim.EnterWriteLock();
        try
        {
            File.Delete(GetFilePath(_folderPath, id));
        }
        finally
        {
            _lockSlim.ExitWriteLock();
        }
    }

    private static string GetFilePath(string folderPath, Guid id) => Path.Combine(folderPath, $"{id}.json");
}