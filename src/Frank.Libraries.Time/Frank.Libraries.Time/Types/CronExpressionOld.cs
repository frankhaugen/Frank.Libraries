using System.Diagnostics;
using System.Text;

namespace Frank.Libraries.Time.Types;

public class CronExpressionOld
{
    private static readonly string[] _daysOfWeek = { "sun", "mon", "tue", "wed", "thu", "fri", "sat" };
    private static readonly string[] _months = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
    private static readonly string[] _daysOfMonth = { "l", "w" };
    private static readonly string[] _specialChars = { "/", "-", "," };
    private static readonly string[] _allChars = { "*", "?" };

    // To enum
    private static readonly Dictionary<string, int> DaysOfWeekNames = new()
    {
        { "SUN", 0 },
        { "MON", 1 },
        { "TUE", 2 },
        { "WED", 3 },
        { "THU", 4 },
        { "FRI", 5 },
        { "SAT", 6 }
    };


    private static readonly Dictionary<string, int> MonthsNames = new()
    {
        { "JAN", 1 },
        { "FEB", 2 },
        { "MAR", 3 },
        { "APR", 4 },
        { "MAY", 5 },
        { "JUN", 6 },
        { "JUL", 7 },
        { "AUG", 8 },
        { "SEP", 9 },
        { "OCT", 10 },
        { "NOV", 11 },
        { "DEC", 12 }
    };

    private bool[]? DaysOfMonthEnabled;
    private bool[]? DaysOfWeekEnabled; // 0 = Sunday
    private bool[]? HoursEnabled;
    private bool[]? MinutesEnabled;
    private bool[]? MonthsEnabled;

    private bool[]? SecondsEnabled;


    private CronExpressionOld()
    {
    }

    /// <summary>
    ///     https://en.wikipedia.org/wiki/Cron
    /// </summary>
    /// <param name="s">
    ///     ┌───────────── minute (0 - 59)
    ///     │ ┌───────────── hour (0 - 23)
    ///     │ │ ┌───────────── day of the month (1 - 31)
    ///     │ │ │ ┌───────────── month (1 - 12)
    ///     │ │ │ │ ┌───────────── day of the week (0 - 6) (Sunday to Saturday; 7 is also Sunday on some systems)
    ///     * * * * *
    /// </param>
    /// <param name="result"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool TryParse(string s, out CronExpressionOld? result)
    {
        if (s == null)
        {
            throw new ArgumentNullException(nameof(s));
        }

        var r = ParseExpression(s, out result);
        return r == null;
    }

    public static CronExpressionOld Parse(string s)
    {
        if (s == null)
        {
            throw new ArgumentNullException(nameof(s));
        }

        var r = ParseExpression(s, out var result);
        if (r != null)
        {
            throw r;
        }

        return result;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append(string.Join(",", FormatField(SecondsEnabled, 0)));
        sb.Append(" ");
        sb.Append(string.Join(",", FormatField(MinutesEnabled, 0)));
        sb.Append(" ");
        sb.Append(string.Join(",", FormatField(HoursEnabled, 0)));
        sb.Append(" ");
        sb.Append(string.Join(",", FormatField(DaysOfMonthEnabled, 1)));
        sb.Append(" ");
        sb.Append(string.Join(",", FormatField(MonthsEnabled, 1)));
        sb.Append(" ");
        sb.Append(string.Join(",", FormatField(DaysOfWeekEnabled, 0)));

        return sb.ToString();
    }

    public DateTime Next(DateTime dt)
    {
        dt = dt.AddMilliseconds(-dt.Millisecond)
               .AddSeconds(-dt.Second);
        Debug.Assert(dt.Millisecond == 0);

        var secondDisplacement = GetDisplacement(SecondsEnabled, dt.Second, 60);
        Debug.Assert(secondDisplacement >= 0 && secondDisplacement < 60);
        if (secondDisplacement != 0)
        {
            dt = dt.AddSeconds(secondDisplacement);
        }

        var minuteDisplacement = GetDisplacement(MinutesEnabled, dt.Minute, 60);
        Debug.Assert(minuteDisplacement >= 0 && minuteDisplacement < 60);
        if (minuteDisplacement != 0)
        {
            dt = dt.AddMinutes(minuteDisplacement);
        }

        var hourDisplacement = GetDisplacement(HoursEnabled, dt.Hour, 24);
        Debug.Assert(hourDisplacement >= 0 && hourDisplacement < 24);
        if (hourDisplacement != 0)
        {
            dt = dt.AddHours(hourDisplacement);
        }

        var daysInMonth = DateTime.DaysInMonth(dt.Year, dt.Month);
        var daysDisplacement = GetDisplacement(DaysOfMonthEnabled, dt.Day - 1, daysInMonth);
        Debug.Assert(daysDisplacement >= 0 && daysDisplacement < 31);
        if (daysDisplacement != 0)
        {
            dt = dt.AddDays(daysDisplacement);
        }

        var monthsDisplacement = GetDisplacement(MonthsEnabled, dt.Month - 1, 12);
        Debug.Assert(monthsDisplacement >= 0 && monthsDisplacement < 12);
        if (monthsDisplacement != 0)
        {
            dt = dt.AddMonths(monthsDisplacement);
        }

        var dowDisplacement = GetDisplacement(DaysOfWeekEnabled, (int)dt.DayOfWeek, 7);
        Debug.Assert(dowDisplacement >= 0 && dowDisplacement < 7);
        if (dowDisplacement != 0)
        {
            dt = dt.AddDays(dowDisplacement);
        }

        return dt;

        static int GetDisplacement(bool[] enabled, int index, int enabledCount)
        {
            if (enabled != null)
            {
                for (var i = 0; i < enabledCount; i++)
                {
                    if (enabled[(index + i) % enabledCount])
                    {
                        return i;
                    }
                }
            }

            return 0;
        }
    }

    private static Exception? ParseExpression(string s, out CronExpressionOld? result)
    {
        result = null;

        var parts = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length < 5)
        {
            return new FormatException("Expression must contains 5 fields");
        }

        result = new CronExpressionOld();

        Exception? exception;
        if ((exception = ParseField(parts[0], 0, 60, null, out result.MinutesEnabled)) != null)
        {
            return exception;
        }

        if ((exception = ParseField(parts[1], 0, 24, null, out result.HoursEnabled)) != null)
        {
            return exception;
        }

        if ((exception = ParseField(parts[2], 1, 31, null, out result.DaysOfMonthEnabled)) != null)
        {
            return exception;
        }

        if ((exception = ParseField(parts[3], 1, 12, MonthsNames, out result.MonthsEnabled)) != null)
        {
            return exception;
        }

        if ((exception = ParseField(parts[4], 0, 7, DaysOfWeekNames, out result.DaysOfWeekEnabled)) != null)
        {
            return exception;
        }

        return null;
    }


    private static Exception? ParseField(string s, int min, int len, Dictionary<string, int>? constants, out bool[]? result)
    {
        result = null;
        if (s == "*")
        {
            return null;
        }

        var parts = s.Split(",", StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length < 1)
        {
            return new FormatException("Field must contains a value");
        }

        result = new bool[len];

        foreach (var part in parts)
        {
            var r = ParseRange(part, min, min + len, constants, out var v1, out var v2);
            if (r != null)
            {
                return r;
            }

            for (var i = v1; i <= v2; i++)
            {
                result[i - min] = true;
            }
        }

        return null;
    }

    private static Exception? ParseRange(string s, int min, int max, Dictionary<string, int>? constants, out int minResult, out int maxResult)
    {
        var parts = s.Split("-", 2, StringSplitOptions.RemoveEmptyEntries);

        minResult = maxResult = 0;

        if (parts.Length < 1)
        {
            return new FormatException($"Value '{s}' noi valid");
        }

        var r = ParseValue(parts[0], constants, out minResult);
        if (r != null)
        {
            return r;
        }

        maxResult = minResult;

        if (parts.Length > 1)
        {
            r = ParseValue(parts[1], constants, out maxResult);
            if (r != null)
            {
                return r;
            }
        }

        if (minResult < min)
        {
            return new FormatException($"Value '{minResult}' out of range (< {min})");
        }

        if (maxResult >= max)
        {
            return new FormatException($"Value '{maxResult}' out of range (> {max - 1})");
        }

        return null;
    }

    private static Exception? ParseValue(string s, Dictionary<string, int>? constants, out int result)
    {
        if (int.TryParse(s, out result))
        {
            return null;
        }

        if (constants != null && constants.TryGetValue(s.ToUpper(), out result))
        {
            return null;
        }

        return new FormatException($"Value '{s}' is not a number or a constant");
    }

    private IEnumerable<string> FormatField(bool[]? array, int min)
    {
        if (array == null)
        {
            yield return "*";
        }
        else
        {
            var i = 0;
            while (i >= 0)
            {
                i = FindIndex(array, v => v, i);
                if (i == -1)
                {
                    break;
                }

                var f = min + i;

                i = NotFindIndex(array, v => v, i);
                if (i == -1)
                {
                    i = array.Length;
                }

                var t = min + i - 1;

                if (f == t)
                {
                    yield return f.ToString();
                }
                else
                {
                    yield return f + "-" + t;
                }
            }
        }
    }

    private static int FindIndex<T>(T[] array, Predicate<T> predicate, int startIndex)
    {
        for (var i = startIndex; i < array.Length; i++)
        {
            if (predicate(array[i]))
            {
                return i;
            }
        }

        return -1;
    }

    private static int NotFindIndex<T>(T[] array, Predicate<T> predicate, int startIndex)
    {
        for (var i = startIndex; i < array.Length; i++)
        {
            if (!predicate(array[i]))
            {
                return i;
            }
        }

        return -1;
    }
}