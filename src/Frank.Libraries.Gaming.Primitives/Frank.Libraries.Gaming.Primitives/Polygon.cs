using System.Collections;
using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public class Polygon : IEnumerable<Vector3>
{
    private readonly Vector3[] _vertices;
    private readonly Edge[] _edges;

    private Polygon()
    {
        _vertices = Array.Empty<Vector3>();
        _edges = Array.Empty<Edge>();
    }

    public Polygon(IEnumerable<Vector3> vertices)
    {
        _vertices = vertices.ToArray();
        _edges = new Edge[_vertices.Length];
        for (var i = 0; i < _vertices.Length; i++)
        {
            var a = _vertices[i];
            var b = _vertices[(i + 1) % _vertices.Length];
            _edges[i] = new Edge(a, b);
        }
    }

    public int Length => _vertices.Length;

    public IEnumerator<Vector3> GetEnumerator() => ((IEnumerable<Vector3>)_vertices).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public Vector3 this[int i]
    {
        get => _vertices[i];
        set => _vertices[i] = value;
    }

    public IEnumerable<Edge> Edges => _edges;

    public Vector3 Position => _vertices.Aggregate((a, b) => a + b) / _vertices.Length;

    public float Width => _vertices.Max(x => x.X) - _vertices.Min(x => x.X);

    public float Height => _vertices.Max(x => x.Y) - _vertices.Min(x => x.Y);

    public float Depth => _vertices.Max(x => x.Z) - _vertices.Min(x => x.Z);

    public override string ToString() => $"Vertices: {string.Join(", ", _vertices)}";
}