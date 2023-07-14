using FluentAssertions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades.Shapes;
using Microsoft.Xna.Framework;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Gaming.MonoEngine;

public class GetBoundsTests
{
    private readonly ITestOutputHelper _outputHelper;

    public GetBoundsTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void GetBounds()
    {
        WorldState.Bounds = new Rectangle(0, 0, 1920, 1080);
        WorldState.PlayArea = new Rectangle(0, 0, 1900, 1000);

        var square = new Square(WorldState.Bounds.Width, WorldState.Bounds.Height, Color.Chartreuse);

        var bounds = square.GetBounds();

        _outputHelper.WriteLine($"Bounds: {bounds}");
        _outputHelper.WriteLine($"WorldState.Bounds: {WorldState.Bounds}");

        bounds.Equals(WorldState.Bounds).Should().BeTrue();
    }
}

public class CheckOutOfBoundsnessTests
{
    private readonly ITestOutputHelper _outputHelper;

    public CheckOutOfBoundsnessTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void GetBounds()
    {
        WorldState.Bounds = new Rectangle(0, 0, 1920, 1080);

        var ball = new Ball(10, Color.White);
        var outerBounds = new OuterBounds(10);

        WorldState.PlayArea = outerBounds.GetBounds();

        var isOutOfBounds = ball.CheckOutOfBoundsness();

        _outputHelper.WriteLine($"isOutOfBounds: {isOutOfBounds}");
        _outputHelper.WriteLine($"ball.Bounds: {ball.GetBounds()}");
        _outputHelper.WriteLine($"WorldState.Bounds: {WorldState.Bounds}");
        _outputHelper.WriteLine($"WorldState.PlayArea: {WorldState.PlayArea}");

        // print positions
        _outputHelper.WriteLine($"ball.Position: {ball.Transform.Position}");


        isOutOfBounds.Should().BeFalse();
    }
}

public class GameObjectBounceTests
{

    private readonly ITestOutputHelper _outputHelper;

    public GameObjectBounceTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void TestBounceOnVerticalBoundary()
    {
        // Arrange
        var gameObject = new Ball(10, Color.Bisque)
        {
            Transform =
            {
                Position = new Vector2(-1, 50) // Place the object beyond the left vertical boundary for this test
            },
            PhysicalProperties =
            {
                Velocity = new Vector2(-50, 0), // Moving leftwards,
                IsBouncy = true,
                IsStatic = false,
                IsCollider = true
            }
        };

        // Act
        gameObject.Bounce();

        // Assert
        Assert.Equal(0, gameObject.Transform.Position.X);                         // The X position should have been corrected to 0
        Assert.Equal(new Vector2(50, 0), gameObject.PhysicalProperties.Velocity); // The velocity should have reflected
    }

    // Similar tests can be created for other boundaries and other conditions
}