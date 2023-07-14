using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;

public static class QuaternionConverter
{
    public static float ToAngle(Quaternion q)
    {
        var angle = 2 * MathF.Acos(q.W);
        return angle;
    }
}