using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Libraries.Json
{
    public class JsonRepository<TEntity> : IJsonRepository<TEntity> where TEntity : JsonEntity
    {
        private readonly IJsonContext<TEntity> _jsonContext;
        private IQueryable<TEntity> _entities = null!;

        public bool PendingChanges { get; private set; }

        public string? Folder { get; }

        public JsonRepository(IJsonContext<TEntity> jsonContext)
        {
            _jsonContext = jsonContext;
            Folder = "";
            PendingChanges = false;
        }

        private async Task InitalizeAsync()
        {
            if (_entities == null)
            {
                _entities = _jsonContext.GetQueryable();
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
                _entities = _jsonContext.GetQueryable();
                PendingChanges = false;
            }
        }

        public async Task SaveChangesAsync()
        {
            if (PendingChanges)
            {
                _jsonContext.SaveChanges();
                PendingChanges = false;
            }
        }

        public async Task<IQueryable<TEntity>> GetAsync()
        {
            await InitalizeAsync();
            return _entities;
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            await InitalizeAsync();
            return _entities.FirstOrDefault(x => x.Id == id)!;
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

        public async Task UpdateAsync(Guid id, TEntity entity)
        {
            await InitalizeAsync();

            var original = await GetByIdAsync(id);

            if (original == null || !_entities.Contains(original))
                throw new ArgumentException($"The original entity does not exist");

            await RemoveAsync(original.Id);
            await AddAsync(entity);
            await ChangesCompleted();
        }

        public Task RemoveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(Guid id)
        {
            await InitalizeAsync();
            PendingChanges = true;
            await ChangesCompleted();
        }

        public async Task RemoveAsync(IEnumerable<TEntity> entities)
        {
            await InitalizeAsync();
            foreach (var entity in entities)
            {
                await RemoveAsync(entity.Id);
            }
            await ChangesCompleted();
        }
    }
}
