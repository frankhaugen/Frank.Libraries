namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Types;

public readonly ref struct Polygon2DColor
{
    private readonly Span<Vertex2DColor> _vertices;
    public Polygon2DColor(Span<Vertex2DColor> vertices) => _vertices = vertices;
    public Span<Vertex2DColor>.Enumerator GetEnumerator() => _vertices.GetEnumerator();

    public Vertex2DColor this[int index]
    {
        get => _vertices[index];
        set => _vertices[index] = value;
    }
}