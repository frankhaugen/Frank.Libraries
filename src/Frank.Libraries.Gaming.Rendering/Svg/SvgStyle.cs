namespace Frank.Libraries.Gaming.Rendering.Svg;

public enum SvgStyle
{
    /// <summary>
    /// Renders the SVG as a string for use in an SVG file, as pure SVG XML code that is.
    /// </summary>
    Normal,

    /// <summary>
    /// Renders the SVG as a string for use in an HTML file, as a HTML image tag.
    /// </summary>
    Html,

    /// <summary>
    /// Renders the SVG as a string for use in a LinqPad file, so no SVG tags are included.
    /// </summary>
    LinqPad
}