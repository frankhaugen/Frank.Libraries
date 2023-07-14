using Frank.Libraries.Gaming.Engines.SilkySmooth.Shaders.FragmentShaders;
using Frank.Libraries.Gaming.Engines.SilkySmooth.Shaders.VertexShader;
using Microsoft.Extensions.Hosting;

namespace Frank.Libraries.Gaming.Engines.SilkySmooth;

public class SilkHost : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var engine = new SilkEngine(new VertexShader(), new FragmentShader());
        engine.Run();

        return Task.CompletedTask;
    }
}