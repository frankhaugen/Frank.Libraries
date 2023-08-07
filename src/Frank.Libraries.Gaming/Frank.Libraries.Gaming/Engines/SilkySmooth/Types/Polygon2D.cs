namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Types;

public readonly ref struct Polygon2D
{
    private readonly Span<Vertex2DColor> _vertices;
    public Polygon2D(Span<Vertex2DColor> vertices) => _vertices = vertices;
    public Span<Vertex2DColor>.Enumerator GetEnumerator() => _vertices.GetEnumerator();

    public Vertex2DColor this[int index]
    {
        get => _vertices[index];
        set => _vertices[index] = value;
    }

    public float[] ToArray()
    {
        var array = new float[_vertices.Length * 5];
        for (var i = 0; i < _vertices.Length; i++)
        {
            var vertex = _vertices[i];
            array[i * 5] = vertex.X;
            array[i * 5 + 1] = vertex.Y;
            array[i * 5 + 2] = vertex.R;
            array[i * 5 + 3] = vertex.G;
            array[i * 5 + 4] = vertex.B;
        }

        return array;
    }

    public uint[] GetIndices()
    {
        var array = new uint[_vertices.Length];
        for (var i = 0; i < _vertices.Length; i++)
        {
            var vertex = _vertices[i];
            array[i] = (uint)vertex.X;
        }

        return array;
    }
}