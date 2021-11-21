using NodaTime;

namespace Frank.Libraries.Time
{
    public class DateService
    {
        private readonly IClock _clock;

        public DateService(IClock clock)
        {
            _clock = clock;
        }

        public int Year => _clock.GetCurrentInstant()
                                 .InUtc()
                                 .Year;

        public int Month => _clock.GetCurrentInstant()
                                  .InUtc()
                                  .Month;

        public int Day => _clock.GetCurrentInstant()
                                .InUtc()
                                .Day;

        public override string ToString() => $"{Year:0000}-{Month:00}-{Day:00}";
    }
}