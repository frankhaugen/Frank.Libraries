using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Core.Parsers.ObjParsing;

public class ObjPolygonParser : IPolygonParser
{
    public Polygon GetPolygon(Memory<byte> bytes)
    {
        var objPolygon = ObjHelper.GetPolygon(bytes);
        var polygon = new Polygon(objPolygon.Vertices.ToArray());
        return polygon;
    }
}