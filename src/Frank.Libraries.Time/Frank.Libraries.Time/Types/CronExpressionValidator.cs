using Frank.Libraries.Time.Parses;
using Frank.Libraries.Time.Validators;

namespace Frank.Libraries.Time.Types;

public class CronExpressionValidator : IValidator<string>
{
    private readonly IValidator<int> _dayOfMonthValidator = new DayOfMonthValidator();
    private readonly IParser<CronDayOfWeekName[]> _dayOfWeekNameParser = new DayOfWeekNameParser();
    private readonly IValidator<int> _dayOfWeekValidator = new DayOfWeekValidator();
    private readonly IValidator<int> _hourValidator = new HourValidator();

    private readonly IParser<int[]> _integerArrayParser = new IntegerArrayParser();
    private readonly IValidator<int> _minuteValidator = new MinuteValidator();
    private readonly IParser<CronMonthName[]> _monthNameParser = new MonthNameParser();

    private readonly IValidator<int> _monthOfYearValidator = new MonthOfYearValidator();
    private readonly IValidator<int> _secondValidator = new SecondValidator();


    public string ValidationMessage { get; set; }

    public bool IsValid(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            ValidationMessage = "Cron expression cannot be null or empty";
            return false;
        }

        var parts = value.Split(' ');

        //if (parts.Length not between 5 and 7)
        if (parts.Length < 5)
        {
            ValidationMessage = "Cron expression must have at least 5 parts";
            return false;
        }

        if (parts.Length > 7)
        {
            ValidationMessage = "Cron expression must have at most 7 parts";
            return false;
        }

        var second = parts[0];
        var minute = parts[1];
        var hour = parts[2];
        var dayOfMonth = parts[3];
        var month = parts[4];
        var dayOfWeek = parts[5];
        var yearOrWeekday = parts[6];

        if (!ValidateSecond(second))
        {
            return false;
        }

        if (!ValidateMinute(minute))
        {
            return false;
        }

        if (!ValidateHour(hour))
        {
            return false;
        }

        if (!ValidateDayOfMonth(dayOfMonth))
        {
            return false;
        }

        if (!ValidateMonth(month))
        {
            return false;
        }

        if (!ValidateDayOfWeek(dayOfWeek))
        {
            return false;
        }

        return true;
    }

    private bool ValidateDayOfWeek(string dayOfWeek)
    {
        if (dayOfWeek == "*")
        {
            // do nothing
        }
        else if (int.TryParse(dayOfWeek, out var dayOfWeekInt))
        {
            if (!_dayOfWeekValidator.IsValid(dayOfWeekInt))
            {
                ValidationMessage = _dayOfWeekValidator.ValidationMessage;
                return false;
            }
        }
        else if (_integerArrayParser.TryParse(dayOfWeek, out var dayOfWeekIntArray))
        {
            foreach (var d in dayOfWeekIntArray)
            {
                if (!_dayOfWeekValidator.IsValid(d))
                {
                    ValidationMessage = _dayOfWeekValidator.ValidationMessage;
                    return false;
                }
            }
        }
        else if (_dayOfWeekNameParser.TryParse(dayOfWeek, out var dayOfWeekNames))
        {
            foreach (var dayOfWeekName in dayOfWeekNames)
            {
                if (!_dayOfWeekValidator.IsValid((int)dayOfWeekName))
                {
                    ValidationMessage = _dayOfWeekValidator.ValidationMessage;
                    return false;
                }
            }
        }
        else
        {
            ValidationMessage = "Day of week must be a valid integer, integer array or month name";
            return false;
        }

        return true;
    }

    private bool ValidateMonth(string month)
    {
        if (month == "*")
        {
            // do nothing
        }
        else if (int.TryParse(month, out var monthInt))
        {
            if (!_monthOfYearValidator.IsValid(monthInt))
            {
                ValidationMessage = _monthOfYearValidator.ValidationMessage;
                return false;
            }
        }
        else if (_integerArrayParser.TryParse(month, out var monthIntArray))
        {
            foreach (var m in monthIntArray)
            {
                if (!_monthOfYearValidator.IsValid(m))
                {
                    ValidationMessage = _monthOfYearValidator.ValidationMessage;
                    return false;
                }
            }
        }
        else if (_monthNameParser.TryParse(month, out var monthNames))
        {
            foreach (var monthName in monthNames)
            {
                if (!_monthOfYearValidator.IsValid((int)monthName))
                {
                    ValidationMessage = _monthOfYearValidator.ValidationMessage;
                    return false;
                }
            }
        }
        else
        {
            ValidationMessage = "Month must be a valid integer, integer array or month name";
            return false;
        }

        return true;
    }

    private bool ValidateDayOfMonth(string dayOfMonth)
    {
        if (dayOfMonth == "*")
        {
            // do nothing
        }
        else if (int.TryParse(dayOfMonth, out var dayOfMonthInt))
        {
            if (!_dayOfMonthValidator.IsValid(dayOfMonthInt))
            {
                ValidationMessage = _dayOfMonthValidator.ValidationMessage;
                return false;
            }
        }
        else if (_integerArrayParser.TryParse(dayOfMonth, out var dayOfMonthIntArray))
        {
            foreach (var d in dayOfMonthIntArray)
            {
                if (!_dayOfMonthValidator.IsValid(d))
                {
                    ValidationMessage = _dayOfMonthValidator.ValidationMessage;
                    return false;
                }
            }
        }
        else
        {
            ValidationMessage = "Day of month must be a valid integer or integer array";
            return false;
        }

        return true;
    }

    private bool ValidateHour(string hour)
    {
        if (hour == "*")
        {
            // Do nothing
        }
        else if (int.TryParse(hour, out var hourInt))
        {
            if (!_hourValidator.IsValid(hourInt))
            {
                ValidationMessage = _hourValidator.ValidationMessage;
                return false;
            }
        }
        else if (_integerArrayParser.TryParse(hour, out var hourIntArray))
        {
            foreach (var h in hourIntArray)
            {
                if (!_hourValidator.IsValid(h))
                {
                    ValidationMessage = _hourValidator.ValidationMessage;
                    return false;
                }
            }
        }
        else
        {
            ValidationMessage = "Hour must be a valid integer or integer array";
            return false;
        }

        return true;
    }

    private bool ValidateMinute(string minute)
    {
        if (minute == "*")
        {
            // Do nothing
        }
        else if (int.TryParse(minute, out var minuteInt))
        {
            if (!_minuteValidator.IsValid(minuteInt))
            {
                ValidationMessage = _minuteValidator.ValidationMessage;
                return false;
            }
        }
        else if (_integerArrayParser.TryParse(minute, out var minuteIntArray))
        {
            foreach (var m in minuteIntArray)
            {
                if (!_minuteValidator.IsValid(m))
                {
                    ValidationMessage = _minuteValidator.ValidationMessage;
                    return false;
                }
            }
        }
        else
        {
            ValidationMessage = "Minute must be a valid integer or integer array";
            return false;
        }

        return true;
    }

    private bool ValidateSecond(string second)
    {
        if (second == "*")
        {
            // Do nothing
        }
        else if (int.TryParse(second, out var secondInt))
        {
            if (!_secondValidator.IsValid(secondInt))
            {
                ValidationMessage = _secondValidator.ValidationMessage;
                return false;
            }
        }
        else if (_integerArrayParser.TryParse(second, out var secondIntArray))
        {
            foreach (var s in secondIntArray)
            {
                if (!_secondValidator.IsValid(s))
                {
                    ValidationMessage = _secondValidator.ValidationMessage;
                    return false;
                }
            }
        }
        else
        {
            ValidationMessage = "Second must be a valid integer or integer array";
            return false;
        }

        return true;
    }
}