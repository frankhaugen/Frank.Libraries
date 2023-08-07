using System.Text;

namespace Frank.Libraries.Fiken.Extensions;

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