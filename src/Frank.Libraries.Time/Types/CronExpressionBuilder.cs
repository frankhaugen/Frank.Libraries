using System;
using System.Linq;

namespace Frank.Libraries.Time.Providers;

public class CronExpressionBuilder
{
    private string _dayOfMonth = "*";
    private string _dayOfWeek = "*";
    private string _hour = "*";
    private string _minute = "*";
    private string _month = "*";
    private string _second = "*";
    private string _year = "*";

    public CronExpressionBuilder EverySecond() => EverySecond(0);
    public CronExpressionBuilder EverySecond(int second) => EverySecond(second, second);
    public CronExpressionBuilder EverySecond(int start, int end) => EverySecond($"{start}-{end}");

    public CronExpressionBuilder EverySecond(string expression)
    {
        _second = expression;
        return this;
    }

    public CronExpressionBuilder EveryMinute() => EveryMinute(0);
    public CronExpressionBuilder EveryMinute(int minute) => EveryMinute(minute, minute);
    public CronExpressionBuilder EveryMinute(int start, int end) => EveryMinute($"{start}-{end}");

    public CronExpressionBuilder EveryMinute(string expression)
    {
        _minute = expression;
        return this;
    }

    public CronExpressionBuilder EveryHour() => EveryHour(0);
    public CronExpressionBuilder EveryHour(int hour) => EveryHour(hour, hour);
    public CronExpressionBuilder EveryHour(int start, int end) => EveryHour($"{start}-{end}");

    public CronExpressionBuilder EveryHour(string expression)
    {
        _hour = expression;
        return this;
    }

    public CronExpressionBuilder EveryDay() => EveryDay(1);
    public CronExpressionBuilder EveryDay(int day) => EveryDay(day, day);
    public CronExpressionBuilder EveryDay(int start, int end) => EveryDay($"{start}-{end}");

    public CronExpressionBuilder EveryDay(string expression)
    {
        _dayOfMonth = expression;
        return this;
    }

    public CronExpressionBuilder EveryMonth() => EveryMonth(1);
    public CronExpressionBuilder EveryMonth(int month) => EveryMonth(month, month);
    public CronExpressionBuilder EveryMonth(int start, int end) => EveryMonth($"{start}-{end}");

    public CronExpressionBuilder EveryMonth(string expression)
    {
        _month = expression;
        return this;
    }

    public CronExpressionBuilder EveryYear() => EveryYear(1970);
    public CronExpressionBuilder EveryYear(int year) => EveryYear(year, year);
    public CronExpressionBuilder EveryYear(int start, int end) => EveryYear($"{start}-{end}");

    public CronExpressionBuilder EveryYear(string expression)
    {
        _year = expression;
        return this;
    }

    public CronExpressionBuilder EveryWeekday() => EveryWeekday(1, 5);
    public CronExpressionBuilder EveryWeekday(int start, int end) => EveryWeekday($"{start}-{end}");

    public CronExpressionBuilder EveryWeekday(string expression)
    {
        _dayOfWeek = expression;
        return this;
    }

    public CronExpressionBuilder EveryWeekend() => EveryWeekend("0,6");

    public CronExpressionBuilder EveryWeekend(string expression)
    {
        _dayOfWeek = expression;
        return this;
    }

    public CronExpressionBuilder EveryMonthName() => EveryMonthName("Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec");

    public CronExpressionBuilder EveryMonthName(string expression)
    {
        _month = expression;
        return this;
    }

    public CronExpressionBuilder EveryMonthName(CronMonthName monthName) => EveryMonthName(monthName.ToString());

    public CronExpressionBuilder EveryMonthName(params CronMonthName[] monthNames)
    {
        var monthNamesString = string.Join(", ", monthNames.Select(x => x.ToString()));
        return EveryMonthName(monthNamesString);
    }


    public CronExpressionBuilder EveryDayOfWeek() => EveryDayOfWeek("Mon, Tue, Wed, Thu, Fri, Sat, Sun");

    public CronExpressionBuilder EveryDayOfWeek(string expression)
    {
        _dayOfWeek = expression;
        return this;
    }

    public CronExpressionBuilder EveryDayOfWeek(DayOfWeek dayOfWeek) => EveryDayOfWeek(dayOfWeek.ToString());

    public CronExpressionBuilder EveryDayOfWeek(params DayOfWeek[] dayOfWeeks)
    {
        var dayOfWeeksString = string.Join(", ", dayOfWeeks.Select(x => x.ToString()));
        return EveryDayOfWeek(dayOfWeeksString);
    }

    public CronExpressionBuilder EveryDayOfWeek(DayOfWeek start, DayOfWeek end) => EveryDayOfWeek($"{start}-{end}");


    public CronExpressionBuilder At(int hour, int minute) => At(hour, minute, 0);

    public CronExpressionBuilder At(int hour, int minute, int second)
    {
        _hour = hour.ToString();
        _minute = minute.ToString();
        _second = second.ToString();
        return this;
    }

    public CronExpressionBuilder At(string hour, string minute) => At(hour, minute, "0");

    public CronExpressionBuilder At(string hour, string minute, string second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
        return this;
    }

    public CronExpressionBuilder At(string time)
    {
        var timeParts = time.Split(':');
        if (timeParts.Length != 3)
        {
            throw new ArgumentException("Time must be in the format HH:mm:ss");
        }

        return At(timeParts[0], timeParts[1], timeParts[2]);
    }

    public CronExpressionBuilder On(int day) => On(day, day);
    public CronExpressionBuilder On(int start, int end) => On($"{start}-{end}");

    public CronExpressionBuilder On(string expression)
    {
        _dayOfMonth = expression;
        return this;
    }

    public CronExpressionBuilder On(CronMonthName monthName) => On(monthName.ToString());

    public CronExpressionBuilder On(params CronMonthName[] monthNames)
    {
        var monthNamesString = string.Join(", ", monthNames.Select(x => x.ToString()));
        return On(monthNamesString);
    }


    public override bool Equals(object? obj) => base.Equals(obj);
    public override int GetHashCode() => base.GetHashCode();
    public override string ToString() => $"{_second} {_minute} {_hour} {_dayOfMonth} {_month} {_dayOfWeek} {_year}";
}