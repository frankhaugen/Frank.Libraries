using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Core.Parsers;

public interface IPolygonParser
{
    Polygon GetPolygon(Memory<byte> bytes);
}