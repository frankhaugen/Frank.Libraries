using System;
using Frank.Libraries.Time.Parses;

namespace Frank.Libraries.Time.Providers;

internal class CronVariantParser : IParser<CronVariant>
{
    public string ParseMessage { get; set; }

    public bool TryParse(string input, out CronVariant result)
    {
        if (Enum.TryParse(input, true, out result))
        {
            return true;
        }

        result = default;
        return false;
    }
}