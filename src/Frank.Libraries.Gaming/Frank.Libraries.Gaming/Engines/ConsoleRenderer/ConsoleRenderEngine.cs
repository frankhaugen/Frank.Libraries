using System.Text;

namespace Frank.Libraries.Gaming.Engines.ConsoleRenderer;

public class ConsoleRenderEngine : IRenderEngine
    {
        private readonly int width;
        private readonly int height;
        private readonly char[,] canvas;
        private readonly Color backgroundColor;

        public ConsoleRenderEngine(int width, int height, Color backgroundColor)
        {
            this.width = width;
            this.height = height;
            canvas = new char[height, width];
            this.backgroundColor = backgroundColor;
        }

        public void Clear()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    canvas[y, x] = ' ';
                }
            }
        }

        public void SetPixel(Coordinate coord, Color color = null)
        {
            if (coord.X >= 0 && coord.X < width && coord.Y >= 0 && coord.Y < height)
            {
                canvas[coord.Y, coord.X] = color != null ? color.Symbol : backgroundColor.Symbol;
            }
        }

        public void Render()
        {
            Console.Clear();
            var lineBuilder = new StringBuilder();

            for (int y = 0; y < height; y++)
            {
                lineBuilder.Clear();
                for (int x = 0; x < width; x++)
                {
                    Console.ForegroundColor = canvas[y, x] == backgroundColor.Symbol ? backgroundColor.ForegroundColor : ConsoleColor.White;
                    Console.BackgroundColor = canvas[y, x] == backgroundColor.Symbol ? backgroundColor.BackgroundColor : ConsoleColor.Black;
                    lineBuilder.Append(canvas[y, x]);
                }

                Console.WriteLine(lineBuilder);
            }
        }
    }