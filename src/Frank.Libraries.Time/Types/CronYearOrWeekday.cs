using System;

namespace Frank.Libraries.Time.Providers;

public class CronYearOrWeekday
{
    public CronYearOrWeekday(string expression)
    {
        var parts = expression.Split(',');
        Years = new int[parts.Length];
        DaysOfWeek = new CronDayOfWeekName[parts.Length];
        for (var i = 0; i < parts.Length; i++)
        {
            if (int.TryParse(parts[i], out var year))
            {
                Years[i] = year;
            }
            else
            {
                DaysOfWeek[i] = (CronDayOfWeekName)Enum.Parse(typeof(CronDayOfWeekName), parts[i], true);
            }
        }
    }

    public int[] Years { get; }
    public CronDayOfWeekName[] DaysOfWeek { get; }
}