using System.Collections;
using System.Numerics;
using System.Web;

namespace Frank.Libraries.DataProcessing.Cloning;

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