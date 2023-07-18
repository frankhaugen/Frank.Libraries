namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Types;

public readonly struct Vertex2DColor
{
    public Vertex2DColor(float x, float y, float r, float g, float b)
    {
        X = x;
        Y = y;
        R = r;
        G = g;
        B = b;
    }

    public float X { get; }
    
    public float Y { get; }
    
    public float R { get; }

    public float G { get; }

    public float B { get; }
}