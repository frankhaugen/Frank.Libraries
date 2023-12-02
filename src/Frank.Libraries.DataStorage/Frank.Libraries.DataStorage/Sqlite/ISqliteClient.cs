namespace Frank.Libraries.DataStorage.Sqlite;

public interface ISqliteClient : IDisposable
{
    void EnsureTableExists<T>() where T : class, IKeyed, new();

    T? GetById<T>(Guid id) where T : class, IKeyed, new();
    IEnumerable<T> GetAll<T>() where T : class, IKeyed, new();
    void Insert<T>(T entity) where T : class, IKeyed, new();
    void Update<T>(T entity) where T : class, IKeyed, new();
    void Delete<T>(T entity) where T : class, IKeyed, new();
}