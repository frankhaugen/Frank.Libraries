using System.Numerics;
using System.Text;

namespace Frank.Libraries.Gaming.Rendering.Console;

internal class ViewportV1
{
    private readonly char[,] _buffer;

    public ViewportV1(Vector3 size)
    {
        _buffer = new char[(int)size.X + 2, (int)size.Y + 2];

        for (var y = 0; y < size.Y; y++)
        {
            for (var x = 0; x < size.X; x++)
            {
                _buffer[x, y] = ' ';
            }
        }

        CreateBorder();
    }

    private void CreateBorder()
    {
        for (var x = 0; x < _buffer.GetLength(0); x++)
        {
            _buffer[x, 0] = '-';
            _buffer[x, _buffer.GetLength(1) - 1] = '-';
        }

        for (var y = 0; y < _buffer.GetLength(1); y++)
        {
            _buffer[0, y] = '|';
            _buffer[_buffer.GetLength(0) - 1, y] = '|';
        }

        _buffer[0, 0] = '+';
        _buffer[_buffer.GetLength(0) - 1, 0] = '+';
        _buffer[0, _buffer.GetLength(1) - 1] = '+';
        _buffer[_buffer.GetLength(0) - 1, _buffer.GetLength(1) - 1] = '+';
    }

    public void Clear()
    {
        for (var y = 0; y < _buffer.GetLength(1); y++)
        {
            for (var x = 0; x < _buffer.GetLength(0); x++)
            {
                _buffer[x, y] = ' ';
            }
        }

        CreateBorder();
    }

    public void SetPixel(Vector3 vector, char pixel)
    {
        var x = (int)vector.X;
        var y = (int)vector.Y;

        if (x >= 0 && x < _buffer.GetLength(0) && y >= 0 && y < _buffer.GetLength(1))
        {
            _buffer[x, _buffer.GetLength(1) - y - 1] = pixel;
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        for (var y = 0; y < _buffer.GetLength(1); y++)
        {
            for (var x = 0; x < _buffer.GetLength(0); x++)
            {
                builder.Append(_buffer[x, y]);
            }

            builder.AppendLine();
        }

        return builder.ToString();
    }
}