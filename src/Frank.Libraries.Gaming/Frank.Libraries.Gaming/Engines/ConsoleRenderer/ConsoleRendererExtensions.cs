using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Gaming.Engines.ConsoleRenderer;

public static class ConsoleRendererExtensions
{
    public static void AddConsoleRenderer(this IServiceCollection services, int width, int height, Color backgroundColor)
    {
        services.AddSingleton<IRenderEngine>(new ConsoleRenderEngine(width, height, backgroundColor));
        services.AddSingleton<ShapeRenderer>();
    }
}