using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Xml
{
    public class XmlContext<T> where T : class, new()
    {
        private List<T> _collection;
        private readonly XmlConfiguration _options;
        private readonly string _filePath;
        private bool _unsavedChanges;

        public XmlContext(IOptions<XmlConfiguration> options = default)
        {
            _options = options.Value;
            if (string.IsNullOrWhiteSpace(_options.DataFolderName))
            {
                _options.DataFolderName = "Data";
            }
            _filePath = Path.Combine(_options.DataFolderName, typeof(T).Name + ".xml");
            Setup();
        }

        private void Setup()
        {
            if (!Directory.Exists(_options.DataFolderName))
            {
                Directory.CreateDirectory(_options.DataFolderName);
            }

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, new List<T>().SerializeObjectToXml());
            }

            _collection = File.ReadAllText(_filePath).DeserializeObjectFromXml<List<T>>();
        }

        public IEnumerable<T> GetCollection()
        {
            _collection = File.ReadAllText(_filePath).DeserializeObjectFromXml<List<T>>();

            if (_collection == null)
            {
                throw new NullReferenceException();
            }

            return _collection;
        }

        public void Add(T item)
        {
            _collection.Append(item);
            _unsavedChanges = true;
        }

        public bool SaveChanges()
        {
            File.WriteAllText(_filePath, _collection.SerializeObjectToXml());
            _unsavedChanges = false;
            return true;
        }
    }
}