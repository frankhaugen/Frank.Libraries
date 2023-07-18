using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Rendering.MonoGame.Extensions;

public static class ColorExtensions
{
    public static Microsoft.Xna.Framework.Color ToColor(this System.Drawing.Color color)
    {
        return new Color(color.R, color.G, color.B, color.A);
    }

    public static System.Drawing.Color ToColor(this Color color)
    {
        return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
    }
}