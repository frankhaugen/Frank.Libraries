using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Extensions.Json
{
    public interface IJsonContext<TConfig> where TConfig : JsonContextConfigurationBase, new()
    {
        Task<IQueryable<TEntity>> GetJsonDataAsync<TEntity>(string folderName = "");
        Task SaveJsonDataAsync<TEntity>(IEnumerable<TEntity> records, string folderName = "", bool indented = true);
    }
}
