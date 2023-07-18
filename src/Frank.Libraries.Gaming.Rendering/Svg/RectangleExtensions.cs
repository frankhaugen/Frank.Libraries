using System.Drawing;

namespace Frank.Libraries.Gaming.Rendering.Svg;

public static class RectangleExtensions
{
    public static string ToSvgViewBox(this Rectangle rectangle)
    {
        return $"{rectangle.X} {rectangle.Y} {rectangle.Width} {rectangle.Height}";
    }
}