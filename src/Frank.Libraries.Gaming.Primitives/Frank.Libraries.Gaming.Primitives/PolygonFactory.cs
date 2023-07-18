using System.Numerics;

namespace Frank.Libraries.Gaming.Primitives;

public static class PolygonFactory
{
    public static Polygon CreateCube(float size) => CreateCube(size, size, size);

    public static Polygon CreateCube(float width, float height, float depth)
    {
        var polygon = new Vector3[8];
        polygon[0] = new Vector3(0, 0, 0);
        polygon[1] = new Vector3(width, 0, 0);
        polygon[2] = new Vector3(width, height, 0);
        polygon[3] = new Vector3(0, height, 0);
        polygon[4] = new Vector3(0, 0, depth);
        polygon[5] = new Vector3(width, 0, depth);
        polygon[6] = new Vector3(width, height, depth);
        polygon[7] = new Vector3(0, height, depth);
        return new Polygon(polygon);
    }

    public static Polygon CreateSphere(float radius, int segments)
    {
        var polygon = new Vector3[segments * segments];
        var step = (float)(Math.PI * 2 / segments);
        for (var i = 0; i < segments; i++)
        {
            var angle = step * i;
            for (var j = 0; j < segments; j++)
            {
                var angle2 = step * j;
                polygon[i * segments + j] = new Vector3((float)Math.Cos(angle) * (float)Math.Cos(angle2) * radius, (float)Math.Sin(angle) * (float)Math.Cos(angle2) * radius, (float)Math.Sin(angle2) * radius);
            }
        }

        return new Polygon(polygon);
    }

    public static Polygon CreateCylinder(float radius, float height, int segments)
    {
        var polygon = new Vector3[segments * 2];
        var step = (float)(Math.PI * 2 / segments);
        for (var i = 0; i < segments; i++)
        {
            var angle = step * i;
            polygon[i] = new Vector3((float)Math.Cos(angle) * radius, (float)Math.Sin(angle) * radius, 0);
            polygon[i + segments] = new Vector3((float)Math.Cos(angle) * radius, (float)Math.Sin(angle) * radius, height);
        }

        return new Polygon(polygon);
    }

    public static Polygon CreateCone(float radius, float height, int segments)
    {
        var polygon = new Vector3[segments + 1];
        var step = (float)(Math.PI * 2 / segments);
        for (var i = 0; i < segments; i++)
        {
            var angle = step * i;
            polygon[i] = new Vector3((float)Math.Cos(angle) * radius, (float)Math.Sin(angle) * radius, 0);
        }

        polygon[segments] = new Vector3(0, 0, height);
        return new Polygon(polygon);
    }

    public static Polygon CreatePyramid(float width, float height)
    {
        var polygon = new Vector3[5];
        polygon[0] = new Vector3(0, 0, 0);
        polygon[1] = new Vector3(width, 0, 0);
        polygon[2] = new Vector3(width, height, 0);
        polygon[3] = new Vector3(0, height, 0);
        polygon[4] = new Vector3(width / 2, height / 2, height);
        return new Polygon(polygon);
    }

    public static Polygon CreateRectangle(float width, float height)
    {
        var polygon = new Vector3[4];
        polygon[0] = new Vector3(0, 0, 0);
        polygon[1] = new Vector3(width, 0, 0);
        polygon[2] = new Vector3(width, height, 0);
        polygon[3] = new Vector3(0, height, 0);
        return new Polygon(polygon);
    }

    public static Polygon CreateCircle(float radius, int sides)
    {
        var polygon = new Vector3[sides];
        var step = (float)(Math.PI * 2 / sides);
        for (var i = 0; i < sides; i++)
        {
            var angle = step * i;
            polygon[i] = new Vector3((float)Math.Cos(angle) * radius, (float)Math.Sin(angle) * radius, 0);
        }

        return new Polygon(polygon);
    }

    public static Polygon CreateTriangle(float width, float height)
    {
        var polygon = new Vector3[3];
        polygon[0] = new Vector3(0, 0, 0);
        polygon[1] = new Vector3(width, 0, 0);
        polygon[2] = new Vector3(width / 2, height, 0);
        return new Polygon(polygon);
    }

    public static Polygon CreateHexagon(float radius)
    {
        var polygon = new Vector3[6];
        const float step = (float)(Math.PI * 2 / 6);
        for (var i = 0; i < 6; i++)
        {
            var angle = step * i;
            polygon[i] = new Vector3((float)Math.Cos(angle) * radius, (float)Math.Sin(angle) * radius, 0);
        }
        return new Polygon(polygon);
    }

    // public static Polygon CreateRagdoll(float scale = 1f)
    // {
    //
    // }
}