using System.Collections;

namespace Frank.Libraries.Json;

public interface IJsonCollection<T> : ICollection<T> where T : JsonEntity, new()
{

}

public class JsonCollection<T> : IJsonCollection<T> where T : JsonEntity, new()
{
    public IEnumerator<T> GetEnumerator() => throw new NotImplementedException();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(T item) => throw new NotImplementedException();

    public void Clear() => throw new NotImplementedException();

    public bool Contains(T item) => throw new NotImplementedException();

    public void CopyTo(T[] array, int arrayIndex) => throw new NotImplementedException();

    public bool Remove(T item) => throw new NotImplementedException();

    public int Count { get; }
    public bool IsReadOnly { get; }
}

public class JsonFile<T> where T: JsonEntity, new()
{
    private readonly DirectoryInfo _directory;
    private readonly FileInfo _file;

    public JsonFile(DirectoryInfo directory)
    {
        _directory = directory;
        if (!_directory.Exists) _directory.Create();

        _file = new FileInfo(Path.Combine(directory.FullName, FileName));
        if (!_file.Exists) _file.Create();
    }

    public string FileName { get; } = $"{typeof(T).GetSafeName()}.json";
}