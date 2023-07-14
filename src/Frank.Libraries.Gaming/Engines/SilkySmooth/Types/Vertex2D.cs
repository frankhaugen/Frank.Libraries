namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Shaders.Types;

public readonly struct Vertex2D
{
    public Vertex2D(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float X { get; }

    public float Y { get; }
}