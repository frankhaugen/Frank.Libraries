using System.Drawing;
using System.Numerics;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Rendering.Svg;

public class SvgRenderer : IRenderer
{
    private readonly SvgRendererOptions _options;

    public SvgRenderer(SvgRendererOptions options) => _options = options;

    public void Render(Scene scene) => throw new NotImplementedException("This method is not implemented. Use the other overload.");

    public void Render(Scene scene, Action<string> callback)
    {
        var svg = new SvgBuilder(_options, scene.SceneSize)
            .WithGridLines()
            .WithBackground(Color.Transparent)
            .WithShapes(scene.GetTransformedShapes())
            .WithLegend()
            .Build();
        callback(svg);
    }
}