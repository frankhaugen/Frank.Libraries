using System.Collections.Generic;
using System.Linq;

namespace Frank.Libraries.Rest;

public sealed class Headers
{
    internal readonly Dictionary<string, string> _headers = new();

    public bool Exist(string key) => _headers.ContainsKey(key);
    public void Add(string key, string value) => _headers.Add(key, value);
    public void Update(string key, string value) => _headers[key] = value;
    public void Delete(string key) => _headers.Remove(key);
    public KeyValuePair<string, string> Get(string key) => _headers.Single(x => x.Equals(key));
}