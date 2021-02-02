using System;
using System.Threading.Tasks;
using Frank.Libraries.Internet.Wikipedia.Models.Summary;
using RestSharp;

namespace Frank.Libraries.Internet.Wikipedia
{
    public class WikipediaClient : IWikipediaClient
    {
        private readonly IRestClient _restClient;

        public WikipediaClient(IRestClient restClient)
        {
            _restClient = restClient;
        }

        /// <summary>
        /// Gets
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public async Task<Summary> GetSummary(string title)
        {
            _restClient.BaseUrl = new Uri("https://en.wikipedia.org/api/rest_v1/page/summary");
            return await _restClient.GetAsync<Summary>(new RestRequest(new Uri(title, UriKind.Relative)));
        }
    }
}