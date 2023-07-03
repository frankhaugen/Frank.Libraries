using System.Globalization;

namespace Frank.Libraries.DataProcessing.Tables;

public record Cell
{
    public Cell()
    {
    }

    public Cell(string? value) => Value = value;

    public string? Value { get; set; }

    public override string? ToString() => Value;

    public static implicit operator Cell(string value) => new(value);

    public static implicit operator string?(Cell cell) => cell.Value;

    public static implicit operator Cell(int value) => new(value.ToString());

    public static implicit operator int?(Cell cell) => int.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(decimal value) => new(value.ToString(CultureInfo.InvariantCulture));

    public static implicit operator decimal?(Cell cell) => decimal.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(double value) => new(value.ToString(CultureInfo.InvariantCulture));

    public static implicit operator double?(Cell cell) => double.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(float value) => new(value.ToString(CultureInfo.InvariantCulture));

    public static implicit operator float?(Cell cell) => float.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(bool value) => new(value.ToString());

    public static implicit operator bool?(Cell cell) => bool.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(DateTime value) => new(value.ToString(CultureInfo.InvariantCulture));

    public static implicit operator DateTime?(Cell cell) => DateTime.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(Guid value) => new(value.ToString());

    public static implicit operator Guid?(Cell cell) => Guid.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(TimeSpan value) => new(value.ToString());

    public static implicit operator TimeSpan?(Cell cell) => TimeSpan.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(byte value) => new(value.ToString());

    public static implicit operator byte?(Cell cell) => byte.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(sbyte value) => new(value.ToString());

    public static implicit operator sbyte?(Cell cell) => sbyte.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(short value) => new(value.ToString());

    public static implicit operator short?(Cell cell) => short.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(ushort value) => new(value.ToString());

    public static implicit operator ushort?(Cell cell) => ushort.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(uint value) => new(value.ToString());

    public static implicit operator uint?(Cell cell) => uint.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(long value) => new(value.ToString());

    public static implicit operator long?(Cell cell) => long.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(ulong value) => new(value.ToString());

    public static implicit operator ulong?(Cell cell) => ulong.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(char value) => new(value.ToString());

    public static implicit operator char?(Cell cell) => char.TryParse(cell.Value, out var result)
        ? result
        : null;

    public static implicit operator Cell(byte[] value) => new(Convert.ToBase64String(value));

    public static implicit operator byte[](Cell cell) => Convert.FromBase64String(cell.Value ?? string.Empty);

    public static implicit operator Cell(Uri value) => new(value.ToString());

    public static implicit operator Uri?(Cell cell) => Uri.TryCreate(cell.Value, UriKind.RelativeOrAbsolute, out var result)
        ? result
        : null;

    public static implicit operator Cell(Version value) => new(value.ToString());

    public static implicit operator Version?(Cell cell) => Version.TryParse(cell.Value, out var result)
        ? result
        : null;
}