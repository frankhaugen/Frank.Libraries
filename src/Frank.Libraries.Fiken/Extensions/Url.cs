using System.Text;

namespace Frank.Libraries.Fiken.Extensions;

public class Url
{
    public Url(string domain, string tld, bool userWww = true, bool isHttps = true)
    {
        Prefix = "http";
        Domain = domain;
        Tld = tld;
        Segments = new Dictionary<int, string>();
        SubDomains = new List<string>();

        if (isHttps)
        {
            Prefix += "s";
        }

        if (userWww)
        {
            SubDomains.Add("www");
        }
    }

    public string Prefix { get; }
    public string Tld { get; }
    public string Domain { get; }
    public Dictionary<int, string> Segments { get; }
    public List<string> SubDomains { get; }
}

public static class UrlExtensions
{
    public static Uri GetUri(this Url url)
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.Append($"{url.Prefix}://");
        if (url.SubDomains.Any())
        {
            stringBuilder.Append($"{string.Join(".", url.SubDomains.Where(x => !string.IsNullOrWhiteSpace(x)))}.");
        }

        stringBuilder.Append($"{url.Domain}.");
        stringBuilder.Append($"{url.Tld}");

        if (url.Segments.Any())
        {
            stringBuilder.Append('/');
            stringBuilder.Append($"{string.Join("/", url.Segments.OrderBy(x => x.Key)
                                                        .Where(x => !string.IsNullOrWhiteSpace(x.Value))
                                                        .Select(x => x.Value))}");
        }

        return new Uri(stringBuilder.ToString());
    }
}