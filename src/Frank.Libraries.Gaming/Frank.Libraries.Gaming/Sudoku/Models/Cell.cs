namespace Frank.Libraries.Gaming.Sudoku.Models;

public class Cell
{
    public Cell(Position position) => Position = position;

    public Position Position { get; set; }
    public int Value { get; set; }

    public string GetName() => $"{Position.X},{Position.Y}";
}