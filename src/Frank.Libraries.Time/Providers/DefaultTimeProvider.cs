using System;

namespace Frank.Libraries.Time.Providers;

public class DefaultTimeProvider : ITimeProvider
{
    public DateTime GetUtcNow() => DateTime.UtcNow;
    public DateOnly GetDate() => DateOnly.FromDateTime(DateTime.UtcNow);
    public TimeOnly GetTime() => TimeOnly.FromDateTime(DateTime.UtcNow);
}