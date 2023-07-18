using System.Diagnostics;
using System.Numerics;
using Frank.Libraries.Gaming.Core;
using Frank.Libraries.Gaming.Engines.ConsoleRenderer;
using Frank.Libraries.Gaming.Engines.MonoEngine;
using Frank.Libraries.Gaming.Engines.SilkySmooth;
using Frank.Libraries.Gaming.Primitives;
using Frank.Libraries.Gaming.Rendering.MonoGame;
using Frank.Libraries.Gaming.Rendering.OpenTk;

var builder = Host.CreateApplicationBuilder();

builder.Logging.ClearProviders();

builder.Services.AddComponent<MonoGameHost>(services =>
{
}, false);

builder.Services.AddComponent<SilkHost>(services =>
{
}, false);

builder.Services.AddComponent<RendererService>(services =>
{
    var consoleWidth = Console.WindowWidth;
    var consoleHeight = Console.WindowHeight;
    services.AddConsoleRenderer(consoleWidth, consoleHeight, new Color(' ', ConsoleColor.White, ConsoleColor.Black));
}, false);

// var host = builder.Build();
// host.Run();

var gameEngine = new GameEngine();
using var monogameEngine = new MonogameEngine(gameEngine);

monogameEngine.Run();

























// var scene = new Scene("Test Scene")
// {
//     BackgroundColor = System.Drawing.Color.Azure
// };
// // var camera = new Camera() { Position = new Vector3(0, 3, 35) };
// var camera = new Camera();
// var box = ShapeFactory.CreateCube(System.Drawing.Color.Chartreuse, 10);
// var gameObject = new GameObject()
// {
//     Name = "Test Object",
//     Shape = box
// };
// scene.GameObjects.Add(gameObject);
// scene.Camera = camera;
// using var renderer = new OpenTkRendererV2(scene);
//
// // renderer.Render(scene);
//
// // long running loop
// var runningTime = TimeSpan.FromSeconds(35);
// var stopwatch = Stopwatch.StartNew();
// while (stopwatch.Elapsed < runningTime)
// {
//     // do something
// }