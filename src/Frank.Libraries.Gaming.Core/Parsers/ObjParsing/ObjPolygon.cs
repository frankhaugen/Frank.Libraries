using System.Numerics;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Core.Parsers.ObjParsing;

internal class ObjPolygon
{
    public List<Vector3> Vertices { get; } = new();
    public List<Vector2> Uvs { get; } = new();
    public List<Vector3> Normals { get; } = new();
    public List<Face> Faces { get; } = new();
}