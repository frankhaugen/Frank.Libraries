using System.Linq.Expressions;
using Frank.Libraries.DataStorage.Abstractions;

namespace Frank.Libraries.DataStorage.Json;

public class JsonRepository<T> : IRepository<T> where T : class, IEntity
{
     private readonly IJsonDirectory<T> _jsonDirectory;

     public JsonRepository(IJsonDirectory<T> jsonDirectory)
     {
         _jsonDirectory = jsonDirectory;
     }

     public async Task<T> GetAsync(Guid id) => await _jsonDirectory.LoadAsync(id) ?? throw new FileNotFoundException($"No {typeof(T).Name} with id {id} found on disk");

     public async Task<IEnumerable<T>> GetAllAsync()
     {
         var list = new List<T>();
         await foreach (var entity in _jsonDirectory.LoadAsync())
         {
             list.Add(entity);
         }
         return list;
     }

     public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
     {
         var list = new List<T>();
         await foreach (var entity in _jsonDirectory.LoadAsync())
         {
             if (predicate.Compile().Invoke(entity))
                    list.Add(entity);
         }
         return list;
     }

     public async Task AddAsync(T entity) => await _jsonDirectory.SaveAsync(entity);

     public async Task RemoveAsync(T entity) => await _jsonDirectory.RemoveAsync(entity.Id);

     public async Task UpdateAsync(T entity) => await _jsonDirectory.SaveAsync(entity);
}