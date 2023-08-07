using System.Collections;

namespace Frank.Libraries.DataProcessing.Cloning;

public class Headers : IEnumerable<Header>
{
    private readonly Dictionary<string, string> _headers = new();

    public void Add(string key, string value) => _headers.Add(key, value);

    public IEnumerator<Header> GetEnumerator() => _headers.Select(x => new Header(x.Key, x.Value))
                                                          .GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}