namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Types;

public readonly struct Vertex3D
{
    public Vertex3D(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public float X { get; }

    public float Y { get; }

    public float Z { get; }
}