using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Extensions.Json
{
    public interface IJsonContext<TEntity> where TEntity : class
    {
        Task<IQueryable<TEntity>> GetJsonDataAsync(string folderName = "");
        Task SaveJsonDataAsync(IEnumerable<TEntity> records, string folderName = "", bool indented = true);
    }
}
