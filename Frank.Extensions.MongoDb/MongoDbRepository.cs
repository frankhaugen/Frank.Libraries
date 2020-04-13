using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Extensions.MongoDb
{
    public class MongoDbRepository<TEntity, TConfig> : IMongoDbRepository<TEntity, TConfig> where TEntity : IMongoEntity, new() where TConfig : MongoDbConfigurationBase, new()
    {
        private readonly IMongoDbContext<TConfig> _mongoDbContext;
        private IQueryable<TEntity> _entities;

        public MongoDbRepository(IMongoDbContext<TConfig> mongoDbContext)
        {
            _mongoDbContext = mongoDbContext;
        }

        public bool PendingChanges { get; private set; }


        private async Task InitalizeAsync()
        {
            if (_entities == null)
            {
                _entities = _mongoDbContext.ReadCollection<TEntity>();
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
                _entities = _mongoDbContext.ReadCollection<TEntity>();
                PendingChanges = false;
            }
        }

        public async Task SaveChangesAsync()
        {
            if (PendingChanges)
            {
                await _mongoDbContext.WriteCollectionAsync(_entities);
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
