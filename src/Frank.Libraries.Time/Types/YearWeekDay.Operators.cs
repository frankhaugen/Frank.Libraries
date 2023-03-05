using System.Numerics;

namespace Frank.Libraries.Time.Providers;

public readonly partial struct YearWeekDay
{
    public static bool operator ==(YearWeekDay left, YearWeekDay right) => left.Equals(right);
    public static bool operator !=(YearWeekDay left, YearWeekDay right) => !left.Equals(right);

    public static bool operator <(YearWeekDay left, YearWeekDay right) => left.CompareTo(right) < 0;
    public static bool operator >(YearWeekDay left, YearWeekDay right) => left.CompareTo(right) > 0;
    public static bool operator <=(YearWeekDay left, YearWeekDay right) => left.CompareTo(right) <= 0;
    public static bool operator >=(YearWeekDay left, YearWeekDay right) => left.CompareTo(right) >= 0;

    public static YearWeekDay operator +(YearWeekDay left, int right) => new(left.Year, left.Week, left.Day + right);
    public static YearWeekDay operator +(YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day + (int)right);
    public static YearWeekDay operator +(YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day + right.Day);

    public static YearWeekDay operator -(YearWeekDay left, int right) => new(left.Year, left.Week, left.Day - right);
    public static YearWeekDay operator -(YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day - (int)right);
    public static YearWeekDay operator -(YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day - right.Day);

    public static YearWeekDay operator *(YearWeekDay left, int right) => new(left.Year, left.Week, left.Day * right);
    public static YearWeekDay operator *(YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day * (int)right);
    public static YearWeekDay operator *(YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day * right.Day);

    public static YearWeekDay operator /(YearWeekDay left, int right) => new(left.Year, left.Week, left.Day / right);
    public static YearWeekDay operator /(YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day / (int)right);
    public static YearWeekDay operator /(YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day / right.Day);

    public static YearWeekDay operator %(YearWeekDay left, int right) => new(left.Year, left.Week, left.Day % right);
    public static YearWeekDay operator %(YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day % (int)right);
    public static YearWeekDay operator %(YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day % right.Day);

    public static YearWeekDay operator ++(YearWeekDay left) => new(left.Year, left.Week, left.Day + 1);
    public static YearWeekDay operator --(YearWeekDay left) => new(left.Year, left.Week, left.Day - 1);

    public static YearWeekDay operator &(YearWeekDay left, int right) => new(left.Year, left.Week, left.Day & right);
    public static YearWeekDay operator &(YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day & (int)right);
    public static YearWeekDay operator &(YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day & right.Day);

    public static YearWeekDay operator |(YearWeekDay left, int right) => new(left.Year, left.Week, left.Day | right);
    public static YearWeekDay operator |(YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day | (int)right);
    public static YearWeekDay operator |(YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day | right.Day);

    public static YearWeekDay operator ^(YearWeekDay left, int right) => new(left.Year, left.Week, left.Day ^ right);
    public static YearWeekDay operator ^(YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day ^ (int)right);
    public static YearWeekDay operator ^(YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day ^ right.Day);

    public static YearWeekDay operator <<(YearWeekDay left, int right) => new(left.Year, left.Week, left.Day << right);
    public static YearWeekDay operator <<(YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day << (int)right);
    public static YearWeekDay operator <<(YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day << right.Day);

    public static YearWeekDay operator >> (YearWeekDay left, int right) => new(left.Year, left.Week, left.Day >> right);
    public static YearWeekDay operator >> (YearWeekDay left, BigInteger right) => new(left.Year, left.Week, left.Day >> (int)right);
    public static YearWeekDay operator >> (YearWeekDay left, YearWeekDay right) => new(left.Year, left.Week, left.Day >> right.Day);

    public static YearWeekDay operator ~(YearWeekDay left) => new(left.Year, left.Week, ~left.Day);

    public static YearWeekDay operator +(YearWeekDay left) => new(left.Year, left.Week, +left.Day);
    public static YearWeekDay operator -(YearWeekDay left) => new(left.Year, left.Week, -left.Day);
}