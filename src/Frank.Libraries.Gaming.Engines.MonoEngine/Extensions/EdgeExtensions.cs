using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;

public static class EdgeExtensions
{
    public static VertexPositionColor[] ToVertexPositionColors(this Edge[] edges, Color color)
    {
        var lineList = new VertexPositionColor[edges.Length * 2];
        for (var i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];
            lineList[i * 2] = new VertexPositionColor(new Vector3(edge.Start.X, edge.Start.Y, 0), color);
            lineList[i * 2 + 1] = new VertexPositionColor(new Vector3(edge.End.X, edge.End.Y, 0), color);
        }

        return lineList;
    }
}