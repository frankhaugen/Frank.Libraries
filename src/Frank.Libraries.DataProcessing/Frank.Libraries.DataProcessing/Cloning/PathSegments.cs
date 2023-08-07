using System.Collections;

namespace Frank.Libraries.DataProcessing.Cloning;

public class PathSegments : IEnumerable<PathSegment>
{
    private readonly SortedList<int, string> _segments = new();

    public void Add(string value) => _segments.Add(_segments.Count, value);

    public void AddRange(IEnumerable<string> values) => values.ToList()
                                                              .ForEach(Add);

    public IEnumerator<PathSegment> GetEnumerator() => _segments.Select(x => new PathSegment(x.Key, x.Value))
                                                                .GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}