using System.Collections.Generic;
using System.Linq;

namespace Frank.Libraries.Rest;

internal record SegmentsSrff
{
    private readonly SortedList<int, string> _segments = new();

    public bool Exist(string value) => _segments.ContainsValue(value);
    public void Add(string value) => _segments.Add(_segments.Count, value);
    public void Update(int key, string value) => _segments[key] = value;
    public void Delete(int key) => _segments.Remove(key);
    public KeyValuePair<int, string> Get(int key) => _segments.Single(x => x.Key.Equals(key));
}