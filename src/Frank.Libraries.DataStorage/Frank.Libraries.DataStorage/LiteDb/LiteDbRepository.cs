namespace Frank.Libraries.DataStorage.LiteDb;

public class LiteDbRepository<T> : IRepository<T> where T : class, IKeyed, new()
{
    private readonly LiteDbDataContext _liteDbDataContext;

    public LiteDbRepository(LiteDbDataContext liteDbDataContext) => _liteDbDataContext = liteDbDataContext;

    public IQueryable<T> GetAll() => _liteDbDataContext.GetCollection<T>()
                                                       .FindAll()
                                                       .AsQueryable();

    public void Add(T entity) => _liteDbDataContext.GetCollection<T>()
                                                   .Insert(entity);

    public void Update(T entity) => _liteDbDataContext.GetCollection<T>()
                                                      .Update(entity);

    public void Delete(Guid id) => _liteDbDataContext.GetCollection<T>()
                                                     .Delete(id);

    public T? GetById(Guid id) => _liteDbDataContext.GetCollection<T>()
                                                    .FindById(id);

    public void SaveChanges()
    {
    }
}