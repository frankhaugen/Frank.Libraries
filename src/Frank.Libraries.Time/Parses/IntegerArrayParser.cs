namespace Frank.Libraries.Time.Parses;

public class IntegerArrayParser : IParser<int[]>
{
    public string ParseMessage { get; set; } = string.Empty;

    public bool TryParse(string value, out int[] result)
    {
        result = null;
        if (string.IsNullOrWhiteSpace(value))
        {
            ParseMessage = "Null or empty value is not allowed";
            return false;
        }

        var split = value.Split(',');
        var intArray = new int[split.Length];
        for (var i = 0; i < split.Length; i++)
        {
            if (!int.TryParse(split[i], out var intResult))
            {
                ParseMessage = $"Unable to parse {split[i]} to an integer";
                return false;
            }

            intArray[i] = intResult;
        }

        result = intArray;
        return true;
    }
}