using NodaTime;

namespace Frank.Libraries.Time;

public class TimeService
{
    private readonly IClock _clock;

    public TimeService(IClock clock) => _clock = clock;

    public int Hours => _clock.GetCurrentInstant()
                              .InUtc()
                              .Hour;

    public int Minutes => _clock.GetCurrentInstant()
                                .InUtc()
                                .Minute;

    public int Seconds => _clock.GetCurrentInstant()
                                .InUtc()
                                .Second;

    public int Milliseconds => _clock.GetCurrentInstant()
                                     .InUtc()
                                     .Millisecond;

    public long UnixTime => _clock.GetCurrentInstant()
                                  .ToUnixTimeMilliseconds();

    public override string ToString() => $"{Hours:00}:{Minutes:00}:{Seconds:00}.{Milliseconds:000}";
}