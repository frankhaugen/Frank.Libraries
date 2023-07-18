using Frank.Libraries.Gaming.Engines.MonoEngine.GameObjects;
using Frank.Libraries.Gaming.Engines.MonoEngine.Premades.Shapes;
using Microsoft.Xna.Framework;

namespace Frank.Libraries.Gaming.Engines.MonoEngine.Premades;

public class OuterBounds : GameObject, IOuterBounds
{
    public OuterBounds(float marging) : base(CreateShape(marging, Color.Chartreuse))
    {
    }

    public override string Name { get; set; } = "OuterBounds";

    private static Shape CreateShape(float margin, Color color)
    {
        var bounds = WorldState.Bounds;
        var square = new Square(bounds.Width - (margin * 2), bounds.Height - (margin * 2), color);
        return square;
    }
}