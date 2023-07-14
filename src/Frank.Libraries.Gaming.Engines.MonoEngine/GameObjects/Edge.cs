using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;

public readonly struct Edge : IEquatable<Edge>
{
    public Vector2 Start { get; }
    public Vector2 End { get; }

    public Edge(Vector2 start, Vector2 end)
    {
        Start = start;
        End = end;
    }

    public override string ToString() => $"[{Start.ToString()} - {End.ToString()}]";

    public static bool operator ==(Edge edge1, Edge edge2) => edge1.Equals(edge2);

    public static bool operator !=(Edge edge1, Edge edge2) => !edge1.Equals(edge2);

    public override bool Equals(object? obj)
    {
        if (obj is Edge edge)
            return Start == edge.Start && End == edge.End;

        return false;
    }

    public bool Equals(Edge other) =>
        Start.Equals(other.Start)
        && End.Equals(other.End);

    public override int GetHashCode() => HashCode.Combine(Start, End);
}