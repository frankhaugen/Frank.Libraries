using Frank.Libraries.Gaming.Engines.ConsoleRenderer;

var builder = Host.CreateApplicationBuilder();

builder.Logging.ClearProviders();

var consoleWidth = Console.WindowWidth;
var consoleHeight = Console.WindowHeight;

builder.Services.AddConsoleRenderer(consoleWidth, consoleHeight, new Color(' ', ConsoleColor.White, ConsoleColor.Black));
builder.Services.AddHostedService<RendererService>();

var host = builder.Build();
host.Run();