using System;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using RestSharp;

namespace Frank.Libraries.Internet.Xkcd;

public class Comic
{
    [JsonPropertyName("num")]
    public int Num { get; set; }

    [JsonPropertyName("day")]
    public string Day { get; set; }

    [JsonPropertyName("year")]
    public string Year { get; set; }

    [JsonPropertyName("month")]
    public string Month { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("news")]
    public string News { get; set; }

    [JsonPropertyName("safe_title")]
    public string SafeTitle { get; set; }

    [JsonPropertyName("transcript")]
    public string Transcript { get; set; }

    [JsonPropertyName("alt")]
    public string Alt { get; set; }

    [JsonPropertyName("img")]
    public string Img { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}

public class XkcdClient
{
    public static async Task<Comic> GetComicAsync(int id = 0)
    {
        var baseUrl = new Uri("https://xkcd.com");
        var client = new RestClient(baseUrl);
        var request = new RestRequest($"/info.{id}.json", Method.GET);
        var response = await client.ExecuteAsync<Comic>(request);
        return response.Data;
    }

    public static async Task<byte[]> GetComicImageAsync(int id = 0)
    {
        var comic = await GetComicAsync(id);
        var client = new RestClient();
        var request = new RestRequest(comic.Img, Method.GET);
        var response = await client.ExecuteAsync<string>(request);
        var base64 = response.Content;
        var bytes = Encoding.UTF8.GetBytes(base64);
        return bytes;
    }
}