namespace Frank.Libraries.Time.Providers;

public readonly partial struct YearMonth
{
    public static bool operator ==(YearMonth left, YearMonth right) => left.Equals(right);
    public static bool operator !=(YearMonth left, YearMonth right) => !left.Equals(right);
    public static bool operator <(YearMonth left, YearMonth right) => left.CompareTo(right) < 0;
    public static bool operator >(YearMonth left, YearMonth right) => left.CompareTo(right) > 0;
    public static bool operator <=(YearMonth left, YearMonth right) => left.CompareTo(right) <= 0;
    public static bool operator >=(YearMonth left, YearMonth right) => left.CompareTo(right) >= 0;
    public static YearMonth operator +(YearMonth left, int right) => new(left.Year.Value + right, left.Month);
    public static YearMonth operator -(YearMonth left, int right) => new(left.Year.Value - right, left.Month);
    public static YearMonth operator ++(YearMonth left) => new(left.Year.Value + 1, left.Month);
    public static YearMonth operator --(YearMonth left) => new(left.Year.Value - 1, left.Month);
    public static YearMonth operator +(YearMonth left, YearMonth right) => new(left.Year.Value + right.Year.Value, left.Month + right.Month);
    public static YearMonth operator -(YearMonth left, YearMonth right) => new(left.Year.Value - right.Year.Value, left.Month - right.Month);
    public static YearMonth operator *(YearMonth left, int right) => new(left.Year.Value * right, left.Month * right);
    public static YearMonth operator /(YearMonth left, int right) => new(left.Year.Value / right, left.Month / right);
    public static YearMonth operator %(YearMonth left, int right) => new(left.Year.Value % right, left.Month % right);
    public static YearMonth operator &(YearMonth left, int right) => new(left.Year.Value & right, left.Month & right);
    public static YearMonth operator |(YearMonth left, int right) => new(left.Year.Value | right, left.Month | right);
    public static YearMonth operator ^(YearMonth left, int right) => new(left.Year.Value ^ right, left.Month ^ right);
    public static YearMonth operator <<(YearMonth left, int right) => new(left.Year.Value << right, left.Month << right);
    public static YearMonth operator >> (YearMonth left, int right) => new(left.Year.Value >> right, left.Month >> right);
    public static YearMonth operator +(int left, YearMonth right) => new(left + right.Year.Value, left + right.Month);
    public static YearMonth operator -(int left, YearMonth right) => new(left - right.Year.Value, left - right.Month);
    public static YearMonth operator *(int left, YearMonth right) => new(left * right.Year.Value, left * right.Month);
    public static YearMonth operator /(int left, YearMonth right) => new(left / right.Year.Value, left / right.Month);
    public static YearMonth operator %(int left, YearMonth right) => new(left % right.Year.Value, left % right.Month);
    public static YearMonth operator &(int left, YearMonth right) => new(left & right.Year.Value, left & right.Month);
    public static YearMonth operator |(int left, YearMonth right) => new(left | right.Year.Value, left | right.Month);
    public static YearMonth operator ^(int left, YearMonth right) => new(left ^ right.Year.Value, left ^ right.Month);
}