using Frank.Libraries.Gaming.Engines.MonoEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Rendering;

public class Renderer : IRenderer
{
    private readonly IGraphicsDeviceContext _graphicsDeviceContext;
    private readonly Camera _camera;
    private readonly SpriteFont _spriteFont;
    private readonly SpriteBatch _spriteBatch;

    public Renderer(IGraphicsDeviceContext graphicsDeviceContext, Camera camera, SpriteFont spriteFont)
    {
        _graphicsDeviceContext = graphicsDeviceContext;
        _camera = camera;
        _spriteFont = spriteFont;
        _spriteBatch = new SpriteBatch(_graphicsDeviceContext.GraphicsDevice);
    }

    public void Draw(GameObject gameObject)
    {
        if (!gameObject.IsActive) return;

        using var effect = CreateBasicEffect();
        foreach (var pass in effect.CurrentTechnique.Passes)
        {
            pass.Apply();
            _graphicsDeviceContext.GraphicsDevice.Draw(gameObject);

            DrawBounds(gameObject.GetBounds(), Color.Lavender);
        }
    }

    public void Draw(TextBox textBox)
    {
        var texboxSize = _spriteFont.MeasureString(textBox.Text);
        var offset = new Vector2(texboxSize.X / 2, texboxSize.Y / 2);
        var position = textBox.Position - offset;

        _spriteBatch.Begin();
        _spriteBatch.DrawString(_spriteFont, textBox.Text, position, textBox.Color);
        _spriteBatch.End();

        if (textBox.ShowBorder)
            DrawRectangle(textBox.Position, texboxSize, Color.White);
    }

    private void DrawBounds(Rectangle bounds, Color color) => DrawPolygon(ToPolygon(bounds), color);

    private void DrawRectangle(Vector2 position, Vector2 size, Color color) => DrawPolygon(ToPolygon(position, size), color);

    // Reused methods to create polygons
    private static Polygon ToPolygon(Rectangle rectangle) =>
        new(new[]
        {
            new Vector2(rectangle.Left, rectangle.Top),
            new Vector2(rectangle.Right, rectangle.Top),
            new Vector2(rectangle.Right, rectangle.Bottom),
            new Vector2(rectangle.Left, rectangle.Bottom)
        });

    private static Polygon ToPolygon(Vector2 position, Vector2 size) =>
        new(new []
        {
            position,
            position + Vector2.UnitX * size.X,
            position + size,
            position + Vector2.UnitY * size.Y
        });

    private void DrawPolygon(Polygon polygon, Color color) =>
        _graphicsDeviceContext.GraphicsDevice.DrawLineList(polygon, color);

    private BasicEffect CreateBasicEffect() =>
        new(_graphicsDeviceContext.GraphicsDevice)
        {
            VertexColorEnabled = true,
            World = Matrix.Identity,
            View = _camera.ViewMatrix,
            Projection = _camera.ProjectionMatrix
        };
}

public class RendererV1 : IRenderer
{
    private readonly IGraphicsDeviceContext _graphicsDeviceContext;
    private readonly Camera _camera;
    private readonly SpriteFont _spriteFont;

    public RendererV1(IGraphicsDeviceContext graphicsDeviceContext, Camera camera, SpriteFont spriteFont)
    {
        _graphicsDeviceContext = graphicsDeviceContext;
        _camera = camera;
        _spriteFont = spriteFont;
    }

    public void Draw(GameObject gameObject)
    {
        if (!gameObject.IsActive) return;

        using var effect = CreateBasicEffect();
        foreach (var pass in effect.CurrentTechnique.Passes)
        {
            pass.Apply();
            _graphicsDeviceContext.GraphicsDevice.Draw(gameObject);

            // DrawBounds(gameObject.GetBounds(), Color.Crimson);
        }
    }

    public void Draw(TextBox textBox)
    {
        using var spriteBatch = new SpriteBatch(_graphicsDeviceContext.GraphicsDevice);

        spriteBatch.Begin();
        spriteBatch.DrawString(_spriteFont, textBox.Text, textBox.Position, textBox.Color);
        spriteBatch.End();

        if (textBox.ShowBorder)
            DrawRectangle(textBox.Position, _spriteFont.MeasureString(textBox.Text), Color.White);
    }

    private void DrawBounds(Rectangle bounds, Color color)
    {
        var polygon = new Polygon(new[]
        {
            new Vector2(bounds.X, bounds.Y),
            new Vector2(bounds.X, bounds.Y + bounds.Height),
            new Vector2(bounds.X + bounds.Width, bounds.Y + bounds.Height),
            new Vector2(bounds.X + bounds.Width, bounds.Y),
            new Vector2(bounds.X, bounds.Y)
        });

        _graphicsDeviceContext.GraphicsDevice.DrawLineList(polygon, color);
    }

    private void DrawRectangle(Vector2 textBoxPosition, Vector2 measureString, Color color)
    {
        var polygon = new Polygon(new[]
        {
            textBoxPosition,
            new Vector2(textBoxPosition.X + measureString.X, textBoxPosition.Y),
            new Vector2(textBoxPosition.X, textBoxPosition.Y + measureString.Y),
            new Vector2(textBoxPosition.X + measureString.X, textBoxPosition.Y + measureString.Y)
        });

        _graphicsDeviceContext.GraphicsDevice.DrawLineList(polygon, color);
    }

    private BasicEffect CreateBasicEffect() =>
        new(_graphicsDeviceContext.GraphicsDevice)
        {
            VertexColorEnabled = true,
            World = Matrix.Identity,
            View = _camera.ViewMatrix,
            Projection = _camera.ProjectionMatrix
        };
}