using Frank.Libraries.DataStorage.Abstractions;

namespace Frank.Libraries.DataStorage.Json;

public interface IJsonDirectory<T> where T : class, IEntity
{
    Task SaveAsync(T entity);
    Task SaveAsync(IEnumerable<T> entities);
    Task<T?> LoadAsync(Guid id);
    IAsyncEnumerable<T> LoadAsync();
    Task RemoveAsync(Guid entityId);
}