namespace Frank.Libraries.Time.Types;

public readonly partial struct YearWeek
{
    public static bool operator ==(YearWeek left, YearWeek right) => left.Equals(right);
    public static bool operator !=(YearWeek left, YearWeek right) => !left.Equals(right);
    public static bool operator <(YearWeek left, YearWeek right) => left.CompareTo(right) < 0;
    public static bool operator >(YearWeek left, YearWeek right) => left.CompareTo(right) > 0;
    public static bool operator <=(YearWeek left, YearWeek right) => left.CompareTo(right) <= 0;
    public static bool operator >=(YearWeek left, YearWeek right) => left.CompareTo(right) >= 0;
    public static implicit operator YearWeek((int year, int week) value) => new(value.year, value.week);
    public static implicit operator (int year, int week)(YearWeek value) => (value.Year, value.Week);
}