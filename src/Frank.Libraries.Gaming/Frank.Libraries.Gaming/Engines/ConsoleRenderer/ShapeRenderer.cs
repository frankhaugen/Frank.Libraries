namespace Frank.Libraries.Gaming.Engines.ConsoleRenderer;

public class ShapeRenderer
{
    private readonly IRenderEngine renderEngine;

    public ShapeRenderer(IRenderEngine renderEngine)
    {
        this.renderEngine = renderEngine;
    }

    public void DrawRectangle(Coordinate topLeft, int width, int height, Color color)
    {
        for (int x = topLeft.X; x < topLeft.X + width; x++)
        {
            for (int y = topLeft.Y; y < topLeft.Y + height; y++)
            {
                renderEngine.SetPixel(new Coordinate(x, y), color);
            }
        }
    }

    public void DrawCircle(Coordinate center, int radius, Color color)
    {
        for (int x = center.X - radius; x <= center.X + radius; x++)
        {
            for (int y = center.Y - radius; y <= center.Y + radius; y++)
            {
                double distance = Math.Sqrt(Math.Pow(x - center.X, 2) + Math.Pow(y - center.Y, 2));
                if (distance <= radius)
                {
                    renderEngine.SetPixel(new Coordinate(x, y), color);
                }
            }
        }
    }
}