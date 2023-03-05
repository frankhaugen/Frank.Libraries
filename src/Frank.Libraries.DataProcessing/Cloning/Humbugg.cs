using System.Collections;
using System.Net;
using System.Numerics;
using System.Web;
using Frank.Libraries.Rest;
using WorkflowCore.Primitives;

namespace Frank.Libraries.DataProcessing.Cloning;

public class Humbugg
{

}


public class UriInfoBase
{
    public PathSegments PathSegments { get; } = new();
    public QueryParameters QueryParameters { get; } = new();
    public HostAddress HostAddress { get; set; }

    public override string ToString() => $"{HostAddress}{PathSegments}{QueryParameters}";
}

public class UriIfo : UriInfoBase
{
    public Headers Headers { get; } = new();
    public string? Content { get; set; }
    public string? Method { get; set; }
}

public class PathSegments : IEnumerable<PathSegment>
{
    private readonly SortedList<int, string> _segments = new();

    public void Add(string value) => _segments.Add(_segments.Count, value);
    public void AddRange(IEnumerable<string> values) => values.ToList().ForEach(Add);

    public IEnumerator<PathSegment> GetEnumerator() => _segments.Select(x => new PathSegment(x.Key, x.Value)).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Response
{
    public string Content { get; set; }
    public bool IsSuccessStatusCode { get; set; }
    public string ReasonPhrase { get; set; }
    public HttpStatusCode StatusCode { get; set; }
}

public class Response<T> : Response
{
    public T? Data { get; set; }
}

public class ClientOptions
{
    public Uri BaseUrl { get; set; }
    public bool ForceInternalToken { get; set; }
    public int? Timeout { get; set; }
}

public class Headers : IEnumerable<Header>
{
    private readonly Dictionary<string, string> _headers = new();

    public void Add(string key, string value) => _headers.Add(key, value);

    public IEnumerator<Header> GetEnumerator() => _headers.Select(x => new Header(x.Key, x.Value)).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public interface IKeyValuePair<out TKey, out TValue>
{
    TKey Key { get; }
    TValue Value { get; }
}

public interface INameValuePair<out TKey, out TValue>
{
    TKey Name { get; }
    TValue Value { get; }
}

public record HostAddress(HttpScheme Scheme = HttpScheme.Http, string HostName = "localhost", int Port = 80);

public record PathSegment(int Key, string Value) : IKeyValuePair<int, string>;

public record QueryParameter(string Name, string? Value) : INameValuePair<string, string?>;

public record Header(string Key, string Value) : IKeyValuePair<string, string>;

public static class HeaderFactory
{
    public static Header Custom(string key, string value) => new(key, value);
    public static Header Autorization(string value) => new(KnownHeaderNames.Authorization, value);
    public static Header Accept(string value) => new(KnownHeaderNames.Accept, value);
    public static Header Allow(string value) => new(KnownHeaderNames.Allow, value);
    public static Header Expires(string value) => new(KnownHeaderNames.Expires, value);
    public static Header ContentDisposition(string value) => new(KnownHeaderNames.ContentDisposition, value);
    public static Header ContentEncoding(string value) => new(KnownHeaderNames.ContentEncoding, value);
    public static Header ContentLanguage(string value) => new(KnownHeaderNames.ContentLanguage, value);
    public static Header ContentLength(string value) => new(KnownHeaderNames.ContentLength, value);
    public static Header ContentLocation(string value) => new(KnownHeaderNames.ContentLocation, value);
    public static Header ContentRange(string value) => new(KnownHeaderNames.ContentRange, value);
    public static Header ContentType(string value) => new(KnownHeaderNames.ContentType, value);
    public static Header Cookie(string value) => new(KnownHeaderNames.Cookie, value);
    public static Header LastModified(string value) => new(KnownHeaderNames.LastModified, value);
    public static Header ContentMD5(string value) => new(KnownHeaderNames.ContentMD5, value);
    public static Header Host(string value) => new(KnownHeaderNames.Host, value);
}

/// <summary>"Stolen" from RestSharp</summary>
public static class KnownHeaderNames
{
    public const string Authorization = "Authorization";
    public const string Accept = "Accept";
    public const string Allow = "Allow";
    public const string Expires = "Expires";
    public const string ContentDisposition = "Content-Disposition";
    public const string ContentEncoding = "Content-Encoding";
    public const string ContentLanguage = "Content-Language";
    public const string ContentLength = "Content-Length";
    public const string ContentLocation = "Content-Location";
    public const string ContentRange = "Content-Range";
    public const string ContentType = "Content-Type";
    public const string Cookie = "Cookie";
    public const string LastModified = "Last-Modified";
    public const string ContentMD5 = "Content-MD5";
    public const string Host = "Host";
}

public class QueryParameters : IEnumerable<QueryParameter>
{
    private readonly List<QueryParameter> _parameters;
    public QueryParameters() => _parameters = new List<QueryParameter>();

    public void Add(string name, string? value) => _parameters.Add(new QueryParameter(name, value));
    public void Add<T>(string name, T? value) where T : INumber<T> => _parameters.Add(new QueryParameter(name, value.ToString()));

    public void Remove(string name) => _parameters.RemoveAll(x => x.Name == name);

    public IEnumerator<QueryParameter> GetEnumerator() => _parameters.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>
    /// Returns a string that can be used in a query string in a URL (e.g. ?name=value&name2=value2) and is URL encoded.
    /// </summary>
    /// <returns></returns>
    public override string ToString() => HttpUtility.UrlEncode(string.Join("&", _parameters.Select(x => $"{x.Name}={x.Value}")));
}
