using Microsoft.Extensions.Hosting;

namespace Frank.Libraries.Gaming.Engines.MonoEngine;

public class MonoGameHost : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var game = new PongGame();
        game.Run();
    }
}