using System.Linq.Expressions;

namespace Frank.Libraries.DataStorage.Abstractions;

public interface IRepository<T> where T : class, IEntity
{
    Task<T> GetAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    Task RemoveAsync(T entity);
    Task UpdateAsync(T entity);
}