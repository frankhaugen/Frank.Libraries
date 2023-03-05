using System;

namespace Frank.Libraries.Time.Providers;

public readonly partial struct YearMonth
{
    public YearMonth(int year, int month)
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

        if (month < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(month));
        }

        if (month > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(month));
        }

        Year = year;
        Month = month;
    }

    public Year Year { get; }
    public int Month { get; }

    public override string ToString() => $"{Year:0000}-{Month:00}";

    public bool Equals(YearMonth other) => Year == other.Year && Month == other.Month;

    public override bool Equals(object? obj) => obj is YearMonth other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Year, Month);

    private int CompareTo(YearMonth right) => Year.CompareTo(right.Year) * 12 + Month.CompareTo(right.Month);
}