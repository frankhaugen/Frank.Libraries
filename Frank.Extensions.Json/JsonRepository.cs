using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Extensions.Json
{
    public class JsonRepository<TEntity, TConfig> : IJsonRepository<TEntity, TConfig> where TConfig : JsonContextConfigurationBase, new()
    {
        private readonly IJsonContext<TConfig> _jsonContext;
        private IQueryable<TEntity> _entities;

        public bool PendingChanges { get; private set; }

        public string? Folder { get; }

        public JsonRepository(IJsonContext<TConfig> jsonContext)
        {
            _jsonContext = jsonContext;
            Folder = "";
            PendingChanges = false;
        }

        private async Task InitalizeAsync()
        {
            if (_entities == null)
            {
                _entities = await _jsonContext.GetJsonDataAsync<TEntity>(Folder);
            }
        }

        private Task ChangesCompleted()
        {
            PendingChanges = true;
            return Task.CompletedTask;
        }

        public async Task DiscardChangesAsync()
        {
            if (PendingChanges)
            {
                _entities = await _jsonContext.GetJsonDataAsync<TEntity>(Folder);
                PendingChanges = false;
            }
        }

        public async Task SaveChangesAsync()
        {
            if (PendingChanges)
            {
                await _jsonContext.SaveJsonDataAsync(_entities);
                PendingChanges = false;
            }
        }

        public async Task<IQueryable<TEntity>> GetAsync()
        {
            await InitalizeAsync();
            return _entities;
        }

        public async Task AddAsync(TEntity entity)
        {
            await InitalizeAsync();
            _entities = _entities.Append(entity);
            await ChangesCompleted();
        }

        public async Task AddAsync(IEnumerable<TEntity> entities)
        {
            await InitalizeAsync();
            foreach (var entity in entities)
            {
                await AddAsync(entity);
            }
            await ChangesCompleted();
        }

        public async Task UpdateAsync(TEntity original, TEntity @new)
        {
            await InitalizeAsync();
            if (!_entities.Contains(original))
                throw new ArgumentException($"The original entity does not exist");

            await RemoveAsync(original);
            await AddAsync(@new);
            await ChangesCompleted();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            await InitalizeAsync();
            _entities = _entities.Where(x => x.GetHashCode() != entity.GetHashCode());
            PendingChanges = true;
            await ChangesCompleted();
        }

        public async Task RemoveAsync(IEnumerable<TEntity> entities)
        {
            await InitalizeAsync();
            foreach (var entity in entities)
            {
                await RemoveAsync(entity);
            }
            await ChangesCompleted();
        }
    }
}
