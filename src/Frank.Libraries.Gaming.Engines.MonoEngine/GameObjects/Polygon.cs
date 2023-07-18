using System.Collections;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;

public readonly record struct Polygon : IEnumerable<Vector2>
{
    private readonly Vector2[] _vertices;

    public Polygon(Vector2[] vertices) => _vertices = vertices;
    public int Length => _vertices.Length;

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<Vector2> GetEnumerator() => _vertices.AsEnumerable()
                                                            .GetEnumerator();

    public Vector2 this[int i] => _vertices[i];
}