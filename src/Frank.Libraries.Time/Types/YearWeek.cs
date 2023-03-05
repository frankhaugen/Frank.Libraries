using System;

namespace Frank.Libraries.Time.Providers;

public readonly partial struct YearWeek
{
    public YearWeek(int year, int week)
    {
        Year = year;
        Week = week;
    }

    public int Year { get; }
    public int Week { get; }

    public override string ToString() => $"{Year:0000}-{Week:00}";

    public bool Equals(YearWeek other) => Year == other.Year && Week == other.Week;

    public override bool Equals(object? obj) => obj is YearWeek other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Year, Week);

    private int CompareTo(YearWeek right)
    {
        var yearComparison = Year.CompareTo(right.Year);
        if (yearComparison != 0)
        {
            return yearComparison;
        }

        return Week.CompareTo(right.Week);
    }

    public static YearWeek Parse(string value)
    {
        var parts = value.Split('-');
        if (parts.Length != 2)
        {
            throw new FormatException("The value is not in the correct format. It should be in the format 'yyyy-ww'.");
        }

        return new YearWeek(int.Parse(parts[0]), int.Parse(parts[1]));
    }

    public static bool TryParse(string value, out YearWeek result)
    {
        try
        {
            result = Parse(value);
            return true;
        }
        catch
        {
            result = default;
            return false;
        }
    }
}