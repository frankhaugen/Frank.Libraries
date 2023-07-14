using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;

public abstract class GameObject
{
    public abstract string Name { get; set; }
    public bool IsActive { get; set; } = true;
    public Transform Transform { get; }
    public Shape Shape { get; }
    public PhysicalProperties PhysicalProperties { get; }

    public GameObject(Shape shape, Transform transform, PhysicalProperties physicalProperties)
    {
        Transform = transform;
        PhysicalProperties = physicalProperties;
        Shape = shape;
    }

    public GameObject(Shape shape, Transform transform)
    {
        Transform = transform;
        PhysicalProperties = new PhysicalProperties();
        Shape = shape;
    }

    public GameObject(Shape shape)
    {
        Transform = new Transform();
        PhysicalProperties = new PhysicalProperties();
        Shape = shape;
    }

    public override string ToString() => $"{Name}:\n"
                                         + $"Position: {Transform.Position}\n"
                                         + $"Velocity: {PhysicalProperties.Velocity}\n"
                                         + $"Bounds: {this.GetBounds()
                                                          .GetCenter()}\n";
}