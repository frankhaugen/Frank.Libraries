using System.Linq.Expressions;
using Frank.Libraries.DataStorage.Abstractions;

namespace Frank.Libraries.DataStorage.InMemory;

public class InMemoryRepository<T> : IRepository<T> where T : class, IEntity
{
    private readonly List<T> _entities = new();

    public Task<T> GetAsync(Guid id) => Task.FromResult(_entities.Single(x => x.Id == id));

    public Task<IEnumerable<T>> GetAllAsync() => Task.FromResult(_entities.AsEnumerable());

    public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate) => Task.FromResult(_entities.Where(predicate.Compile()));

    public Task AddAsync(T entity)
    {
        _entities.Add(entity);
        return Task.CompletedTask;
    }

    public Task RemoveAsync(T entity)
    {
        _entities.Remove(entity);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(T entity)
    {
        var index = _entities.FindIndex(x => x.Id == entity.Id);
        _entities[index] = entity;
        return Task.CompletedTask;
    }
}