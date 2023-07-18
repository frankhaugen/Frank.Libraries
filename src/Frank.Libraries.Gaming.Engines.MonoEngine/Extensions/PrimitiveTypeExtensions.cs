using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;

public static class PrimitiveTypeExtensions
{
    public static int GetVertexCount(this PrimitiveType primitiveType)
    {
        return primitiveType switch
        {
            PrimitiveType.LineList      => 2,
            PrimitiveType.LineStrip     => 2,
            PrimitiveType.TriangleList  => 3,
            PrimitiveType.TriangleStrip => 3,
            PrimitiveType.PointList     => 3,
            _                           => 0
        };
    }
}