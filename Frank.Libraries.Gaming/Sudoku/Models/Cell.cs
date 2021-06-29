namespace Frank.Libraries.Gaming.Sudoku.Models
{
    public class Cell
    {
        public Cell(Position position)
        {
            Position = position;
        }

        public Position Position { get; set; }
        public int Value { get; set; }

        public string GetName() => $"{Position.X},{Position.Y}";
    }

    public class Position
    {
        public static Position Initialize(int x, int y) => new() { X = x, Y = y };

        public int X { get; set; }
        public int Y { get; set; }
    }
}