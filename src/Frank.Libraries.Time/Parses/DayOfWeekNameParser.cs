using System;
using System.Collections.Generic;
using Frank.Libraries.Time.Parses;

namespace Frank.Libraries.Time.Providers;

internal class DayOfWeekNameParser : IParser<CronDayOfWeekName[]>
{
    public string ParseMessage { get; set; }

    public bool TryParse(string input, out CronDayOfWeekName[] result)
    {
        var parts = input.Split(',');
        var names = new List<CronDayOfWeekName>();
        foreach (var part in parts)
        {
            if (Enum.TryParse<CronDayOfWeekName>(part, true, out var name))
            {
                names.Add(name);
            }
            else
            {
                result = null;
                return false;
            }
        }

        result = names.ToArray();
        return true;
    }
}