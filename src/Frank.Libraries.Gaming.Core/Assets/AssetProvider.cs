using Frank.Libraries.Gaming.Core.FileProviders;
using Frank.Libraries.Gaming.Core.Parsers.ObjParsing;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Core.Assets;

public static class PolygonAssetProvider
{
    public static Polygon GetTeapot()
    {
        var provider = new ManifestFileProvider();
        var parser = new ObjPolygonParser();
        var bytes = provider.GetFile("teapot.obj");
        var polygon = parser.GetPolygon(bytes);
        return polygon;
    }
}