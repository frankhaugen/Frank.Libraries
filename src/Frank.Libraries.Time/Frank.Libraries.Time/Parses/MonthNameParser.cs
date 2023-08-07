using Frank.Libraries.Time.Types;

namespace Frank.Libraries.Time.Parses;

public class MonthNameParser : IParser<CronMonthName[]>
{
    public string ParseMessage { get; set; } = string.Empty;

    public bool TryParse(string value, out CronMonthName[] result)
    {
        result = null;
        if (string.IsNullOrWhiteSpace(value))
        {
            ParseMessage = "Null or empty value is not allowed";
            return false;
        }

        var split = value.Split(',');
        var monthNames = new CronMonthName[split.Length];
        for (var i = 0; i < split.Length; i++)
        {
            if (!Enum.TryParse(split[i], true, out CronMonthName monthName))
            {
                ParseMessage = $"Unable to parse {split[i]} to a month name";
                return false;
            }

            monthNames[i] = monthName;
        }

        result = monthNames;
        return true;
    }
}