namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Types;

public readonly ref struct Polygon3D
{
    private readonly Span<Vertex3DColor> _vertices;
    public Polygon3D(Span<Vertex3DColor> vertices) => _vertices = vertices;
    public Span<Vertex3DColor>.Enumerator GetEnumerator() => _vertices.GetEnumerator();

    public Vertex3DColor this[int index]
    {
        get => _vertices[index];
        set => _vertices[index] = value;
    }
}