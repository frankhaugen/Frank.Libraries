using NodaTime;

namespace Frank.Libraries.Time.Providers;

public class NodaTimeFixedClockProvider : ITimeProvider
{
    private readonly Instant _instant;

    public NodaTimeFixedClockProvider(Instant instant) => _instant = instant;

    public DateTime GetUtcNow() => _instant.ToDateTimeUtc();

    public DateOnly GetDate() => _instant.InUtc()
                                         .Date.ToDateOnly();

    public TimeOnly GetTime() => _instant.InUtc()
                                         .TimeOfDay.ToTimeOnly();
}