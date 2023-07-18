using System.Numerics;
using System.Text;

namespace Frank.Libraries.Gaming.Core.Parsers.ObjParsing;

internal static class ObjHelper
{
    public static ObjPolygon GetPolygon(Memory<byte> bytes)
    {
        var polygon = new ObjPolygon();
        var lines = Encoding.UTF8.GetString(bytes.ToArray()).Split('\n');
        foreach (var line in lines)
        {
            var parts = line.Split(' ');
            switch (parts[0])
            {
                case "v":
                    polygon.Vertices.Add(new Vector3(float.Parse(parts[1]), float.Parse(parts[2]), float.Parse(parts[3])));
                    break;
            }
        }

        return polygon;
    }
}