using NodaTime;

namespace Frank.Libraries.Time.Providers;

public class NodaTimeProvider : ITimeProvider
{
    private readonly IClock _clock;

    public NodaTimeProvider(IClock clock) => _clock = clock;

    public DateTime GetUtcNow() => _clock.GetCurrentInstant()
                                         .ToDateTimeUtc();

    public DateOnly GetDate() => _clock.GetCurrentInstant()
                                       .InUtc()
                                       .Date.ToDateOnly();

    public TimeOnly GetTime() => _clock.GetCurrentInstant()
                                       .InUtc()
                                       .TimeOfDay.ToTimeOnly();
}