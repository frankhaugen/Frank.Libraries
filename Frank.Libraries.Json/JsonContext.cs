using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Frank.Libraries.Json
{
    public class JsonContext<TEntity> : IJsonContext<TEntity> where TEntity : JsonEntity
    {

        private List<TEntity> _collection;
        private readonly List<TEntity> _tempCollection;
        private readonly JsonConfiguration _options;
        private readonly string _filePath;
        private bool _unsavedChanges;

        public JsonContext(IOptions<JsonConfiguration> options)
        {
            _options = options!.Value;
            _collection = new List<TEntity>();
            _tempCollection = new List<TEntity>();

            if (string.IsNullOrWhiteSpace(_options.Folder))
            {
                _options.Folder = Path.Combine(Directory.GetCurrentDirectory(), "Data");
            }
            _filePath = Path.Combine(_options.Folder, typeof(TEntity).Name + ".json");
            Setup();
        }

        private void Setup()
        {
            if (!Directory.Exists(_options.Folder))
            {
                Directory.CreateDirectory(_options.Folder!);
            }

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, new List<TEntity>().ToJson());
            }
            _collection = File.ReadAllText(_filePath).FromJson<List<TEntity>>();
        }

        public IEnumerable<TEntity> GetCollection()
        {
            if (!_collection.Any())
                _collection = File.ReadAllText(_filePath).FromJson<List<TEntity>>();

            return _collection;
        }

        public IQueryable<TEntity> GetQueryable()
        {
            if (!_collection.Any())
                _collection = File.ReadAllText(_filePath).FromJson<List<TEntity>>();

            return _collection.AsQueryable();
        }

        public TEntity GetById(Guid id)
        {
            return _collection.FirstOrDefault(x => x.Id == id)!;
        }

        public void Delete(Guid id)
        {
            var entity = _collection.FirstOrDefault(x => x.Id == id)!;
            _collection.Remove(entity);
            _unsavedChanges = true;
        }

        public void Add(TEntity item)
        {
            _tempCollection.Add(item);
            _unsavedChanges = true;
        }

        public void Add(List<TEntity> items)
        {
            _tempCollection.AddRange(items);
            _unsavedChanges = true;
        }

        public bool SaveChanges()
        {
            if (!_unsavedChanges) return true;

            GetCollection();
            _collection.AddRange(_tempCollection);
            File.WriteAllText(_filePath, _collection.ToJson());
            _tempCollection.Clear();

            GetCollection();

            _unsavedChanges = false;
            return true;
        }

        public void DiscardChanges()
        {
            _tempCollection.Clear();
            _unsavedChanges = false;
        }
    }
}
