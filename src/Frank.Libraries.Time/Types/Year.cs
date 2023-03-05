using System;

namespace Frank.Libraries.Time.Providers;

public readonly partial struct Year
{
    public Year(int year)
    {
        // Guard
        if (year < DateOnly.MinValue.Year)
        {
            throw new ArgumentOutOfRangeException(nameof(year));
        }

        if (year > DateOnly.MaxValue.Year)
        {
            throw new ArgumentOutOfRangeException(nameof(year));
        }

        Value = year;
    }

    public int Value { get; }

    public override string ToString() => $"{Value:0000}";

    public bool Equals(Year other) => Value == other.Value;

    public override bool Equals(object? obj) => obj is Year other && Equals(other);

    public override int GetHashCode() => Value;

    internal int CompareTo(Year right) => Value.CompareTo(right.Value);
}