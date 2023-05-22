namespace Frank.Libraries.Time.Types;

internal readonly record struct CronExpressionBase(string Second, string Minute, string Hour, string DayOfMonth, string Month, string DayOfWeek, string YearOrWeekday)
{
    public CronExpressionBase(string expression) : this(Extract(expression, 0), Extract(expression, 1), Extract(expression, 2), Extract(expression, 3), Extract(expression, 4), Extract(expression, 5), Extract(expression, 6))
    {
    }

    private static string Extract(string expression, int index)
    {
        var parts = expression.Split(' ');
        return parts.Length > index
            ? parts[index]
            : "*";
    }

    public override string ToString() => $"{Second} {Minute} {Hour} {DayOfMonth} {Month} {DayOfWeek} {YearOrWeekday}";

    public static implicit operator CronExpressionBase(string expression) => new(expression);
    public static implicit operator string(CronExpressionBase expression) => expression.ToString();

    public static bool operator ==(CronExpressionBase? left, CronExpressionBase? right) => left.Equals(right);
    public static bool operator !=(CronExpressionBase? left, CronExpressionBase? right) => !(left == right);
}