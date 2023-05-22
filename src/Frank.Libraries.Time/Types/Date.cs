namespace Frank.Libraries.Time.Types;

public readonly record struct Date(Year Year, int Month, int Day)
{
    public Date(int year, int month, int day) : this(new Year(year), month, day)
    {
    }

    public override string ToString() => $"{Year:0000}-{Month:00}-{Day:00}";
}