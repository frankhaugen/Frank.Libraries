using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Physics;

public class PhysicsEngine
{
    public List<IForce> Forces { get; } = new();

    public PhysicsEngine()
    {
        Forces.Add(new GravityForce());
        Forces.Add(new DragForce());
    }

    public void Update(Scene scene, TimeSpan deltaTime)
    {
        foreach (var gameObject in scene.GameObjects)
        {
            var force = Forces.Select(x => x.Calculate(gameObject, deltaTime)).Where(x => x.HasValue).Select(x => x.Value).Aggregate((x, y) => x + y);
            gameObject.Transform.Translate(force);
        }
    }
}