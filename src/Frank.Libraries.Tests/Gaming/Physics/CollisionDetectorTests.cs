using System.Numerics;
using System.Text;
using FluentAssertions;
using Frank.Libraries.Gaming.Core;
using Frank.Libraries.Gaming.Physics;
using Frank.Libraries.Gaming.Primitives;
using Frank.Libraries.Gaming.Rendering;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.Gaming.Physics;

public class CollisionDetectorTests
{
    private readonly ITestOutputHelper _outputHelper;

    public CollisionDetectorTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void DetectCollisions_ShouldReturnEmpty_WhenNoCollisions()
    {
        // Arrange
        var polygonA = PolygonFactory.CreateSphere(10, 15).Translate(new Vector3(-20, 0, 0));
        var polygonB = PolygonFactory.CreateSphere(10, 15).Translate(new Vector3(20, 0, 0));
        var polygons = new List<Polygon> { polygonA, polygonB };

        // Act
        var result = CollisionDetector.DetectCollisions(polygons);

        // Assert
        result.Should().BeEmpty();

        _outputHelper.WriteLine("DetectCollisions_ShouldReturnEmpty_WhenNoCollisions executed successfully.");
    }

    [Fact]
    public void DetectCollisions_ShouldReturnNonEmpty_WhenCollisionsExist()
    {
        // Arrange
        var polygonA = PolygonFactory.CreateSphere(10, 15).Translate(new Vector3(-1, 3, 1));
        var polygonB = PolygonFactory.CreateSphere(10, 15).Translate(new Vector3(1, 1, 3));
        var polygons = new List<Polygon> { polygonA, polygonB };

        // Act
        var result = CollisionDetector.DetectCollisions(polygons);

        // Assert
        var stringBuilder = new StringBuilder();

        foreach (var polygon in polygons)
        {
            stringBuilder.AppendLine("Polygon:");
            stringBuilder.AppendLine($"Local Position: {polygon.Position}");
            stringBuilder.AppendLine($"Vertices: {polygon.Count()}");
            stringBuilder.AppendLine($"Edges: {polygon.Edges.Count()}");
            stringBuilder.AppendLine($"With: {polygon.Width}");
            stringBuilder.AppendLine($"Height: {polygon.Height}");
            stringBuilder.AppendLine($"Depth: {polygon.Depth}");
            foreach (var vector in polygon.Skip(0).Take(15))
            {
                stringBuilder.AppendLine($"Vertex: {vector}");
            }
            stringBuilder.AppendLine();
        }

        _outputHelper.WriteLine(stringBuilder.ToString());
        result.Should().NotBeEmpty();

    }
}