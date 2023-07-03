using Microsoft.Extensions.Hosting;

namespace Frank.Libraries.Gaming.Engines.ConsoleRenderer;

public class RendererService : BackgroundService
{
    private readonly IRenderEngine renderEngine;
    private readonly ShapeRenderer shapeRenderer;

    public RendererService(IRenderEngine renderEngine, ShapeRenderer shapeRenderer)
    {
        this.renderEngine = renderEngine;
        this.shapeRenderer = shapeRenderer;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            renderEngine.Clear();
            shapeRenderer.DrawRectangle(new Coordinate(10, 10), 10, 10, new Color('#', ConsoleColor.Red, ConsoleColor.Black));
            shapeRenderer.DrawCircle(new Coordinate(40, 20), 10, new Color('*', ConsoleColor.Green, ConsoleColor.Black));
            renderEngine.Render();

            await Task.Delay(1000, stoppingToken); // Render every 1 second
        }
    }
}