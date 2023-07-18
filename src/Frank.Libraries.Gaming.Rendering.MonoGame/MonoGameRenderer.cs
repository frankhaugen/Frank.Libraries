using Frank.Libraries.Gaming.Primitives;
using Frank.Libraries.Gaming.Rendering.MonoGame.Extensions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Rendering.MonoGame;

public class MonoGameRenderer : IRenderer
{
    private readonly IGraphicsDeviceContext _graphicsDeviceContext;

    public MonoGameRenderer(IGraphicsDeviceContext graphicsDeviceContext) => _graphicsDeviceContext = graphicsDeviceContext;

    public void Render(Scene scene)
    {
        var shapes = scene.GetTransformedShapes();

        using var effect = CreateBasicEffect(scene.Camera);
        foreach (var pass in effect.CurrentTechnique.Passes)
        {
            pass.Apply();
            foreach (var shape in shapes)
            {
                _graphicsDeviceContext.GraphicsDevice.Draw(shape);
            }
        }
    }

    public void Render(Scene scene, Action<string> callback) => throw new NotImplementedException();

    private BasicEffect CreateBasicEffect(Camera camera) =>
        new(_graphicsDeviceContext.GraphicsDevice)
        {
            VertexColorEnabled = true,
            World = Matrix.Identity,
            View = camera.GetViewMatrix(),
            Projection = camera.GetProjectionMatrix()
        };
}