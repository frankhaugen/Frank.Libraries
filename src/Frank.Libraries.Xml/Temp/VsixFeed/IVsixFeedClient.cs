using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;

namespace Frank.Libraries.Xml.Temp.VsixFeed;

public interface IVsixFeedClient
{
    Task<IReadOnlyList<Entry>> Get();
}

public class VsixFeedClient : IVsixFeedClient
{
    public async Task<IReadOnlyList<Entry>> Get() => throw new NotImplementedException(); //(await new RestClient("https://www.vsixgallery.com/feed").GetAsync<Feed>(new RestRequest())).Entry;
}