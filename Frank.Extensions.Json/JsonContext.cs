using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Frank.Extensions.Json
{
    public class JsonContext<TEntity> : IJsonContext<TEntity> where TEntity : class, new()
    {
        private readonly string _rootDataFolder;

        private readonly JsonSerializerOptions _serializerOptions;

        public JsonContext(string rootDataFolder = "Data")
        {
            _serializerOptions = new JsonSerializerOptions();
            var directory = Directory.CreateDirectory(rootDataFolder);
            _rootDataFolder = directory.FullName;
        }

        public async Task<IQueryable<TEntity>> GetJsonDataAsync(string folderName = "")
        {
            var path = Path.Combine(_rootDataFolder, folderName, nameof(TEntity) + "s.json");

            if (!File.Exists(path))
            {
                return new List<TEntity>().AsQueryable();
            }

            var json = await File.ReadAllTextAsync(path);
            var records = JsonSerializer.Deserialize<IEnumerable<TEntity>>(json);
            return records.AsQueryable();
        }

        public async Task SaveJsonDataAsync(IEnumerable<TEntity> records, string folderName = "", bool indented = true)
        {
            _serializerOptions.WriteIndented = indented;
            var directory = Directory.CreateDirectory(Path.Combine(_rootDataFolder, folderName));

            var path = Path.Combine(directory.FullName, $"{nameof(TEntity)}s.json");
            var json = JsonSerializer.Serialize(records, _serializerOptions);
            await File.WriteAllTextAsync(path, json);
        }
    }
}
