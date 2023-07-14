using Frank.Libraries.Gaming.Engines.ConsoleRenderer;
using Frank.Libraries.Gaming.Engines.MonoGameEngine;
using Frank.Libraries.Gaming.Engines.SilkySmooth;

var builder = Host.CreateApplicationBuilder();

builder.Logging.ClearProviders();


builder.Services.AddComponent<MonoGameHost>(services =>
{
}, true);

builder.Services.AddComponent<SilkHost>(services =>
{
}, false);

builder.Services.AddComponent<RendererService>(services =>
{
    var consoleWidth = Console.WindowWidth;
    var consoleHeight = Console.WindowHeight;
    services.AddConsoleRenderer(consoleWidth, consoleHeight, new Color(' ', ConsoleColor.White, ConsoleColor.Black));
}, false);

var host = builder.Build();
host.Run();