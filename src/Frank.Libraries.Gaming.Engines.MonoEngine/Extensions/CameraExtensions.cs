using Frank.Libraries.Gaming.Engines.MonoGameEngine.Rendering;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;

public static class CameraExtensions
{
    public static void SyncToViewport(this Camera camera, Viewport viewport)
    {
        camera.Target = viewport.GetCenter()
                                .ToVector3();
        camera.AspectRatio = viewport.AspectRatio;
        camera.Position = viewport.GetCenter()
                                  .ToVector3()
                          + camera.Position;
    }

    public static void SyncToBounds(this Camera camera, Rectangle bounds)
    {
        camera.Target = bounds.GetCenter()
                              .ToVector3();
        // camera.AspectRatio = bounds.Width / bounds.Height;
        camera.Position = bounds.GetCenter()
                                .ToVector3()
                          + camera.Position;
    }
}