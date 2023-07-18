using System.Drawing;

namespace Frank.Libraries.Gaming.Rendering.Svg;

public class SvgRendererOptions
{
    public SvgStyle Style { get; set; } = SvgStyle.Normal;
    public bool IncludeGridLines { get; set; } = true;
}