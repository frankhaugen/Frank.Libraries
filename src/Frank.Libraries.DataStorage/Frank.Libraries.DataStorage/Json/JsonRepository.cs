namespace Frank.Libraries.DataStorage.Json;

public class JsonRepository<T> : IRepository<T> where T : class, IKeyed, new()
{
    private readonly JsonTable<T> _table;

    public JsonRepository(JsonContext context)
    {
        _table = context.GetTable<T>();
    }

    public IQueryable<T> GetAll() => _table.GetAll()
                                           .AsQueryable();

    public void Add(T entity) => _table.Save(entity.Id, entity);

    public void Update(T entity) => _table.Save(entity.Id, entity);

    public void Delete(Guid id) => _table.Delete(id);

    public T? GetById(Guid id) => _table.Get(id);

    public void SaveChanges()
    {
    }
}