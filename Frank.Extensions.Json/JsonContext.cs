using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Frank.Extensions.Json
{
    public class JsonContext<TConfig> : IJsonContext<TConfig> where TConfig : JsonContextConfigurationBase, new()
    {
        private readonly TConfig _options;

        private readonly JsonSerializerOptions _serializerOptions;

        public JsonContext(IOptions<TConfig> options)
        {
            _options = options.Value;
            _serializerOptions = new JsonSerializerOptions();
            var directory = Directory.CreateDirectory(_options.RootFolder);
            _options.RootFolder = directory.FullName;
        }

        public async Task<IQueryable<TEntity>> GetJsonDataAsync<TEntity>(string folderName = "")
        {
            var path = Path.Combine(_options.RootFolder, folderName, typeof(TEntity).Name + "s.json");

            if (!File.Exists(path))
            {
                return new List<TEntity>().AsQueryable();
            }

            var json = await File.ReadAllTextAsync(path);
            var records = JsonSerializer.Deserialize<IEnumerable<TEntity>>(json);
            return records.AsQueryable();
        }

        public async Task SaveJsonDataAsync<TEntity>(IEnumerable<TEntity> records, string folderName = "", bool indented = true)
        {
            _serializerOptions.WriteIndented = indented;
            var directory = Directory.CreateDirectory(Path.Combine(_options.RootFolder, folderName));

            var path = Path.Combine(directory.FullName, $"{typeof(TEntity).Name}s.json");
            var json = JsonSerializer.Serialize(records, _serializerOptions);
            await File.WriteAllTextAsync(path, json);
        }
    }
}
