using System.Text;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Rendering.Console3D;

public class Console3DRenderer : IRenderer
{
    public void Render(Scene scene)
    {

    }

    public void Render(Scene scene, Action<string> callback)
    {
        var console3DRenderer = new Console3DRendererBuilder()
                                .WithShapes(scene.GetTransformedShapes())
                                .Build();

        callback(console3DRenderer);
    }
}

public class Console3DRendererBuilder
{
    private readonly StringBuilder _builder = new();

    public Console3DRendererBuilder WithShapes(IEnumerable<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            WithShape(shape);
        }
        return this;
    }

    public Console3DRendererBuilder WithShape(Shape shape)
    {

        return this;
    }




    public string Build() => _builder.ToString();
}