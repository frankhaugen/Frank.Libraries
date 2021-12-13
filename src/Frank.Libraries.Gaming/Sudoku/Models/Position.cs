namespace Frank.Libraries.Gaming.Sudoku.Models;

public class Position
{
    public static Position Initialize(int x, int y) => new() { X = x, Y = y };

    public int X { get; set; }
    public int Y { get; set; }
}