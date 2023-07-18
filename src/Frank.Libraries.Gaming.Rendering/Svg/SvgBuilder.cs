using System.Drawing;
using System.Text;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Rendering.Svg;

public class SvgBuilder
{
    private readonly StringBuilder _svgBuilder = new();
    private readonly SvgRendererOptions _options;
    private const int IndentSize = 4;
    private readonly Rectangle _viewBox;

    public SvgBuilder(SvgRendererOptions options, Rectangle viewBox)
    {
        _options = options;
        _viewBox = viewBox;

        switch (_options.Style)
        {
            case SvgStyle.Normal:
                _svgBuilder.AppendLine("<svg xmlns='http://www.w3.org/2000/svg' version='1.1'>");
                break;
            case SvgStyle.Html:
                _svgBuilder.AppendLine($"<svg viewBox='{_viewBox.ToSvgViewBox()}' xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink'>");
                break;
            case SvgStyle.LinqPad:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public SvgBuilder WithGridLines(int gridLineSpacing = 10)
    {
        if (!_options.IncludeGridLines)
            return this;

        _svgBuilder.AppendLine($"<g id='grid'>");
        for (var x = _viewBox.X; x < _viewBox.Width; x += gridLineSpacing)
        {
            var strokeOpacity = (x == 0)
                ? "1"
                : "0.25";
            var line = $"{Indent(1)}<line x1='{x}' y1='{_viewBox.Y}' x2='{x}' y2='{_viewBox.Height}' stroke='gray' stroke-width='1' stroke-opacity='{strokeOpacity}' />";
            _svgBuilder.AppendLine(line);
        }

        for (var y = _viewBox.Y; y < _viewBox.Height; y += gridLineSpacing)
        {
            var strokeOpacity = (y == 0)
                ? "1"
                : "0.25";
            var line = $"{Indent(1)}<line x1='{_viewBox.X}' y1='{y}' x2='{_viewBox.Width}' y2='{y}' stroke='gray' stroke-width='1' stroke-opacity='{strokeOpacity}' />";
            _svgBuilder.AppendLine(line);
        }
        _svgBuilder.AppendLine($"</g>");

        return this;
    }

    public SvgBuilder WithLegend()
    {
        var fontSize = 3;
        var length = 7;
        var textOffset = 5;

        _svgBuilder.AppendLine($"<g id='legend'>"); // Starting the group
        _svgBuilder.AppendLine($"{Indent(1)}<line x1='0' y1='0' x2='{textOffset}' y2='0' stroke='black' stroke-width='1' />");
        _svgBuilder.AppendLine($"{Indent(1)}<text x='{length}' y='0' font-size='{fontSize}'>X</text>");
        _svgBuilder.AppendLine($"{Indent(1)}<line x1='0' y1='0' x2='0' y2='{textOffset}' stroke='black' stroke-width='1' />");
        _svgBuilder.AppendLine($"{Indent(1)}<text x='0' y='{length}' font-size='{fontSize}'>Y</text>");
        _svgBuilder.AppendLine($"</g>"); // Ending the group

        return this;
    }

    public SvgBuilder WithBackground(Color color)
    {
        var backgroundRect = $"<rect x='{_viewBox.X}' y='{_viewBox.Y}' width='{_viewBox.Width}' height='{_viewBox.Height}' fill='{ColorTranslator.ToHtml(color)}' />";
        _svgBuilder.AppendLine(backgroundRect);
        return this;
    }

    public SvgBuilder WithShapes(IEnumerable<Shape> shapes, int strokeWidth = 1)
    {
        _svgBuilder.AppendLine($"<g id='shapes'>");
        foreach (var shape in shapes) WithShape(shape, strokeWidth);
        _svgBuilder.AppendLine($"</g>");
        return this;
    }

    public SvgBuilder WithShape(Shape shape, int strokeWidth = 1)
    {
        var polygon = shape.Polygon;
        var color = shape.Color;
        var stroke = Color.Black;
        var points = string.Join(" ", polygon.Select(vertex => $"{vertex.X},{vertex.Y}"));
        var polygonString = $"{Indent(1)}<polygon points='{points}' fill='{ColorTranslator.ToHtml(color)}' stroke='{ColorTranslator.ToHtml(stroke)}' stroke-width='{strokeWidth}' />";

        _svgBuilder.AppendLine(polygonString);
        return this;
    }

    public string Build()
    {
        switch (_options.Style)
        {
            case SvgStyle.Normal:
            case SvgStyle.Html:
                _svgBuilder.AppendLine("</svg>");
                break;
            case SvgStyle.LinqPad:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return _svgBuilder.ToString();
    }

    private static string Indent(int indentLevel) => new(' ', IndentSize * indentLevel);
}