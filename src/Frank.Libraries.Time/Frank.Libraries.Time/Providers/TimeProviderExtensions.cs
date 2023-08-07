using System.Globalization;
using Frank.Libraries.Time.Types;

namespace Frank.Libraries.Time.Providers;

public static class TimeProviderExtensions
{
    public static YearWeek GetYearWeek(this ITimeProvider timeProvider)
    {
        var now = timeProvider.GetUtcNow();
        return new YearWeek(now.Year, ISOWeek.GetWeekOfYear(now));
    }
}