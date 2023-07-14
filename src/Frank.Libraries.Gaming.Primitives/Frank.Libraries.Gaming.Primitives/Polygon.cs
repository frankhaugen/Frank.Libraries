using System.Collections;
using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public class Polygon<T> : IEnumerable<T> where T : struct
{
    private readonly T[] _vertices;

    internal Polygon(params T[] vertices)
    {
        if (typeof(T) != typeof(Vector2) && typeof(T) != typeof(Vector3))
        {
            throw new ArgumentException($"Invalid type {typeof(T).Name}. Only Vector2 and Vector3 are supported.");
        }

        _vertices = vertices ?? throw new ArgumentNullException(nameof(vertices));
    }

    public int Length => _vertices.Length;

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)_vertices).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public T this[int i] => _vertices[i];
}