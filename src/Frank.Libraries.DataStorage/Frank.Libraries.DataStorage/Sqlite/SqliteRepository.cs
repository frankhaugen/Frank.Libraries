namespace Frank.Libraries.DataStorage.Sqlite;

public class SqliteRepository<T> : IRepository<T> where T : class, IKeyed, new()
{
    private readonly ISqliteClient _sqliteClient;

    public SqliteRepository(ISqliteClient sqliteClient)
    {
        _sqliteClient = sqliteClient;
        _sqliteClient.EnsureTableExists<T>();
    }

    public IQueryable<T> GetAll() => _sqliteClient.GetAll<T>()
                                                  .AsQueryable();

    public void Add(T entity) => _sqliteClient.Insert(entity);

    public void Update(T entity) => _sqliteClient.Update(entity);

    public void Delete(Guid id) => _sqliteClient.Delete<T>(GetById(id)!);

    public T? GetById(Guid id) => _sqliteClient.GetById<T>(id);

    public void SaveChanges()
    {
    }
}