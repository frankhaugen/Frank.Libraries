using System;
using NodaTime;

namespace Frank.Libraries.Time.Providers;

public class NodaTimeSystemClockProvider : ITimeProvider
{
    public DateTime GetUtcNow() => SystemClock.Instance.GetCurrentInstant()
                                              .ToDateTimeUtc();

    public DateOnly GetDate() => SystemClock.Instance.GetCurrentInstant()
                                            .InUtc()
                                            .Date.ToDateOnly();

    public TimeOnly GetTime() => SystemClock.Instance.GetCurrentInstant()
                                            .InUtc()
                                            .TimeOfDay.ToTimeOnly();
}