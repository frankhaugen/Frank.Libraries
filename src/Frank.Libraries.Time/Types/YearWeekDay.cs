using System;

namespace Frank.Libraries.Time.Providers;

public readonly partial struct YearWeekDay : IEquatable<YearWeekDay>
{
    public YearWeekDay(int year, int week, int day)
    {
        // Guards
        if (year < DateOnly.MinValue.Year)
        {
            throw new ArgumentOutOfRangeException(nameof(year));
        }

        if (year > DateOnly.MaxValue.Year)
        {
            throw new ArgumentOutOfRangeException(nameof(year));
        }

        if (week < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(week));
        }

        if (week > 53)
        {
            throw new ArgumentOutOfRangeException(nameof(week));
        }

        if (day < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(day));
        }

        if (day > 7)
        {
            throw new ArgumentOutOfRangeException(nameof(day));
        }


        Year = year;
        Week = week;
        Day = day;
    }

    public int Year { get; }
    public int Week { get; }
    public int Day { get; }

    public override string ToString() => $"{Year:0000}-{Week:00}-{Day:0}";

    public bool Equals(YearWeekDay other) =>
        Year == other.Year
        && Week == other.Week
        && Day == other.Day;

    public override bool Equals(object? obj) => obj is YearWeekDay other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Year, Week, Day);

    private int CompareTo(YearWeekDay right)
    {
        var yearComparison = Year.CompareTo(right.Year);
        if (yearComparison != 0)
        {
            return yearComparison;
        }

        var weekComparison = Week.CompareTo(right.Week);
        if (weekComparison != 0)
        {
            return weekComparison;
        }

        return Day.CompareTo(right.Day);
    }
}