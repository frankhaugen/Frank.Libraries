namespace Frank.Libraries.DataStorage;

public interface IRepository<T> where T : class, IKeyed, new()
{
    IQueryable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(Guid id);
    T? GetById(Guid id);
    void SaveChanges();
}