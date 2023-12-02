using MongoDB.Driver;

namespace Frank.Libraries.DataStorage.MongoDb;

public class MongoDbRepository<T> : IRepository<T> where T : class, IKeyed, new()
{
    private readonly IMongoCollection<T> _collection;

    public MongoDbRepository(MongoDbContext context) => _collection = context.GetCollection<T>();

    public IQueryable<T> GetAll() => _collection.AsQueryable();

    public void Add(T entity) => _collection.InsertOne(entity);

    public void Update(T entity) => _collection.ReplaceOne(x => x.Id == entity.Id, entity);

    public void Delete(Guid id) => _collection.DeleteOne(x => x.Id == id);

    public T? GetById(Guid id) => _collection.Find(x => x.Id == id)
                                             .FirstOrDefault();

    public void SaveChanges()
    {
    }
}