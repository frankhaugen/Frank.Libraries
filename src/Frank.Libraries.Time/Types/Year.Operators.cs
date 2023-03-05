using System;
using System.Globalization;
using System.Numerics;

namespace Frank.Libraries.Time.Providers;

public readonly partial struct Year
{
    public static Year operator +(Year year, int value) => new(year.Value + value);
    public static Year operator +(Year year, BigInteger value) => new(year.Value + (int)value);
    public static Year operator +(Year year, Year value) => new(year.Value + value.Value);

    public static Year operator -(Year year, int value) => new(year.Value - value);
    public static Year operator -(Year year, BigInteger value) => new(year.Value - (int)value);
    public static Year operator -(Year year, Year value) => new(year.Value - value.Value);

    public static Year operator *(Year year, int value) => new(year.Value * value);
    public static Year operator *(Year year, BigInteger value) => new(year.Value * (int)value);
    public static Year operator *(Year year, Year value) => new(year.Value * value.Value);

    public static Year operator /(Year year, int value) => new(year.Value / value);
    public static Year operator /(Year year, BigInteger value) => new(year.Value / (int)value);
    public static Year operator /(Year year, Year value) => new(year.Value / value.Value);

    public static Year operator %(Year year, int value) => new(year.Value % value);
    public static Year operator %(Year year, BigInteger value) => new(year.Value % (int)value);
    public static Year operator %(Year year, Year value) => new(year.Value % value.Value);

    public static Year operator ++(Year year) => new(year.Value + 1);
    public static Year operator --(Year year) => new(year.Value - 1);

    public static bool operator ==(Year year, int value) => year.Value == value;
    public static bool operator ==(Year year, Year value) => year.Value == value.Value;
    public static bool operator ==(Year year, BigInteger value) => year.Value == (int)value;

    public static bool operator !=(Year year, int value) => !(year == value);
    public static bool operator !=(Year year, BigInteger value) => !(year == value);
    public static bool operator !=(Year year, Year value) => !(year == value);

    public static bool operator <(Year year, int value) => year.Value < value;
    public static bool operator <(Year year, BigInteger value) => year.Value < (int)value;
    public static bool operator <(Year year, Year value) => year.Value < value.Value;

    public static bool operator >(Year year, int value) => year.Value > value;
    public static bool operator >(Year year, BigInteger value) => year.Value > (int)value;
    public static bool operator >(Year year, Year value) => year.Value > value.Value;

    public static bool operator <=(Year year, int value) => year.Value <= value;
    public static bool operator <=(Year year, BigInteger value) => year.Value <= (int)value;
    public static bool operator <=(Year year, Year value) => year.Value <= value.Value;

    public static bool operator >=(Year year, int value) => year.Value >= value;
    public static bool operator >=(Year year, BigInteger value) => year.Value >= (int)value;
    public static bool operator >=(Year year, Year value) => year.Value >= value.Value;

    public static implicit operator int(Year year) => year.Value;
    public static implicit operator Year(int year) => new(year);
    public static implicit operator BigInteger(Year year) => year.Value;
    public static implicit operator Year(BigInteger year) => new((int)year);
    public static implicit operator Year(string year) => new(int.Parse(year));
    public static implicit operator string(Year year) => year.Value.ToString(CultureInfo.InvariantCulture);
    public static implicit operator Year(DateTime dateTime) => new(dateTime.Year);
    public static implicit operator DateTime(Year year) => new(year.Value, 1, 1);
    public static implicit operator Year(DateOnly dateOnly) => new(dateOnly.Year);
    public static implicit operator DateOnly(Year year) => new(year.Value, 1, 1);
    public static implicit operator Year(DateTimeOffset dateTimeOffset) => new(dateTimeOffset.Year);
    public static implicit operator DateTimeOffset(Year year) => new(year.Value, 1, 1, 0, 0, 0, TimeSpan.Zero);
    public static implicit operator Year(YearWeek yearWeek) => new(yearWeek.Year);
    public static implicit operator YearWeek(Year year) => new(year.Value, 1);
    public static implicit operator Year(YearWeekDay yearWeekDay) => new(yearWeekDay.Year);
    public static implicit operator YearWeekDay(Year year) => new(year.Value, 1, 1);
}