namespace Frank.Libraries.Time.Providers;

public enum CronVariant
{
    SecondPrecision,
    MinutePrecision
}

public readonly partial record struct Cron
{
    internal CronExpressionBase Expression { get; init; }

    public static implicit operator Cron(string expression) => new() { Expression = new CronExpressionBase(expression) };
    public static implicit operator string(Cron cron) => cron.Expression.ToString();

    public override string ToString() => Expression.ToString();
}