using System.Threading.Tasks;
using Frank.Libraries.Internet.Wikipedia.Models.Summary;

namespace Frank.Libraries.Internet.Wikipedia
{
    public interface IWikipediaClient
    {
        /// <summary>
        /// Gets
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        Task<Summary> GetSummary(string title);
    }
}