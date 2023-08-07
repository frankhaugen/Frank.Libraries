namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Types;

public readonly struct Vertex3DColor
{
    public Vertex3DColor(float x, float y, float z, float r, float g, float b)
    {
        X = x;
        Y = y;
        Z = z;
        R = r;
        G = g;
        B = b;
    }

    public float X { get; }

    public float Y { get; }

    public float Z { get; }

    public float R { get; }

    public float G { get; }

    public float B { get; }
}