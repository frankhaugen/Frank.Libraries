namespace Frank.Libraries.Gaming.Engines.ConsoleRenderer;

public interface IRenderEngine
{
    void Clear();
    void SetPixel(Coordinate coord, Color color = null);
    void Render();
}