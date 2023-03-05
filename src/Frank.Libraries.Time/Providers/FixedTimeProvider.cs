using System;

namespace Frank.Libraries.Time.Providers;

public class FixedTimeProvider : ITimeProvider
{
    private readonly DateTime _dateTime;

    public FixedTimeProvider(DateTime dateTime) => _dateTime = dateTime;

    public DateTime GetUtcNow() => _dateTime;
    public DateOnly GetDate() => DateOnly.FromDateTime(_dateTime);
    public TimeOnly GetTime() => TimeOnly.FromDateTime(_dateTime);
}