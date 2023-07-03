namespace Frank.Libraries.Gaming.Engines.ConsoleRenderer;

public class Color
{
    public char Symbol { get; }
    public ConsoleColor ForegroundColor { get; }
    public ConsoleColor BackgroundColor { get; }

    public Color(char symbol, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
    {
        Symbol = symbol;
        ForegroundColor = foregroundColor;
        BackgroundColor = backgroundColor;
    }
}