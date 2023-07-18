using System.Drawing;
using System.Numerics;
using Frank.Libraries.Gaming.Core;
using Frank.Libraries.Gaming.Core.Assets;
using Frank.Libraries.Gaming.Primitives;
using Frank.Libraries.Gaming.Rendering.Console;
using Frank.Libraries.Gaming.Rendering.Svg;
using Frank.Libraries.Gaming.Rendering.ThreeJsRenderer;
using VarDump;
using VarDump.Visitor;
using Xunit.Abstractions;
using Color = System.Drawing.Color;
using Vector3 = System.Numerics.Vector3;

namespace Frank.Libraries.Tests.Gaming.Renderers;

public class RenderTests
{
    private readonly ITestOutputHelper _outputHelper;

    public RenderTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }


    [Fact]
    public void ConsoleRenderer()
    {
        // Arrange
        var renderer = new ConsoleRenderer(200, 5f);
        var sphere = PolygonFactory.CreateCircle(10, 15);
        var scene = new Scene("Test");
        var camera = new Camera();

        var gameObject = new GameObject()
        {
            Transform = new Transform()
            {
                Position = new Vector3(25, 25, 0),
                Rotation = Quaternion.Identity,
                Scale = 1f
            },
            Shape = new Shape()
            {
                Polygon = sphere,
                Color = Color.Chartreuse
            }
        };

        scene.GameObjects.Add(gameObject);
        scene.Camera = camera;

        // Act
        renderer.Render(scene, x =>
        {
            _outputHelper.WriteLine(x);
        });

        // Assert
    }

    [Fact]
    public void SvgRenderer()
    {
        // Arrange
        var options = new SvgRendererOptions()
        {
            // ViewBox = new Rectangle(-50, -50, 200, 150),
            Style = SvgStyle.Html
        };
        var renderer = new SvgRenderer(options);
        var sphere = PolygonFactory.CreateCircle(10, 15);
        var scene = new Scene("Test");
        var camera = new Camera();

        var gameObject = new GameObject()
        {
            Transform = new Transform()
            {
                Position = new Vector3(-25, 25, 0),
                Rotation = Quaternion.Identity,
                Scale = 1f
            },
            Shape = new Shape()
            {
                Polygon = sphere,
                Color = Color.Chartreuse
            }
        };

        scene.GameObjects.Add(gameObject);
        scene.Camera = camera;


        // Act
        renderer.Render(scene, x =>
        {
            _outputHelper.WriteLine(x);
        });

        // Assert
    }

    [Fact]
    public void ThreeJsRenderer()
    {
        // Arrange
        var renderer = new ThreeJsRenderer();
        var scene = new Scene("Test");
        // var sphere = GameObjectFactory.CreateGameObject(TransformFactory.CreateTransform(new Vector3(-10, 0, -25)), ShapeFactory.CreateSpere(Color.Chartreuse, 30, 32));
        var box = GameObjectFactory.CreateGameObject(TransformFactory.CreateTransform(new Vector3(10, 0, 25)), ShapeFactory.CreateCube(Color.Chartreuse, 10));

        // var teaPot = GameObjectFactory.CreateGameObject(TransformFactory.CreateTransform(new Vector3(0, 0, 0)), new Shape() { Polygon = AssetProvider.GetTeapot(), Color = Color.Chartreuse });

        // scene.GameObjects.Add(sphere);
        scene.GameObjects.Add(box);
        // scene.GameObjects.Add(teaPot);

        scene.Camera = new Camera()
        {
            FieldOfView = 75,
            NearPlaneDistance = 1,
            FarPlaneDistance = 1000,
            Position = new Vector3(0, 60, 200)
        };

        var csharpDumper = new CSharpDumper(new DumpOptions() {IgnoreDefaultValues = false, IgnoreNullValues = false, WritablePropertiesOnly = false, MaxDepth = 15});
        var csharp = csharpDumper.Dump(scene);

        _outputHelper.WriteLine(csharp);

        // Act
        // renderer.Render(scene, x =>
        // {
        //     _outputHelper.WriteLine(x);
        // });

        // Assert
    }
}