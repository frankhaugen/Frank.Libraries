using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Frank.Libraries.Xml
{
    public class XmlContext<TEntity> : IXmlContext<TEntity> where TEntity : XmlEntity, new()
    {
        private readonly List<TEntity> _collection;
        private readonly List<TEntity> _tempCollection;
        private readonly XmlConfiguration _options;
        private readonly string _filePath;
        private bool _unsavedChanges;

        public XmlContext(IOptions<XmlConfiguration>? options = default)
        {
            _options = options!.Value;

            _collection = new List<TEntity>();
            _tempCollection = new List<TEntity>();

            if (string.IsNullOrWhiteSpace(_options.Folder))
            {
                _options.Folder = Path.Combine(Directory.GetCurrentDirectory(), "Data");
            }
            _filePath = Path.Combine(_options.Folder, typeof(TEntity).Name + ".xml");
            Setup();
        }

        private void Setup()
        {
            if (!Directory.Exists(_options.Folder))
            {
                Directory.CreateDirectory(_options.Folder);
            }

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, new List<TEntity>().SerializeObjectToXml());
            }
            _collection.AddRange(File.ReadAllText(_filePath).DeserializeObjectFromXml<List<TEntity>>());
        }

        public IEnumerable<TEntity> GetCollection()
        {
            if (!_collection.Any())
                _collection.AddRange(File.ReadAllText(_filePath).DeserializeObjectFromXml<List<TEntity>>());

            return _collection;
        }

        public void Add(TEntity entity)
        {
            _tempCollection.Add(entity);
            _unsavedChanges = true;
        }

        public void Add(List<TEntity> entities)
        {
            _tempCollection.AddRange(entities);
            _unsavedChanges = true;
        }

        public TEntity GetById(Guid id)
        {
            return _collection.FirstOrDefault(x => x.Id == id)!;
        }

        public void Update(Guid id, TEntity entity)
        {
            var original = _collection.FirstOrDefault(x => x.Id == id);
            if (original == null) return;
            _collection.Remove(original);
            _collection.Add(entity);
            _unsavedChanges = true;
        }

        public void Delete(Guid id)
        {
            var entity = _collection.FirstOrDefault(x => x.Id == id);
            if (entity == null) return;
            _collection.Remove(entity);
            _unsavedChanges = true;
        }

        public bool SaveChanges()
        {
            if (!_unsavedChanges) return true;

            GetCollection();
            _collection.AddRange(_tempCollection);
            File.WriteAllText(_filePath, _collection.SerializeObjectToXml());
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
