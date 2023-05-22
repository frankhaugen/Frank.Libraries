using System.Text.RegularExpressions;

namespace Frank.Libraries.Gaming.Common.Dice;

public static class DiceRollExpressionParser
{
    private const string Regex = @"(\d*)d(\d+)";

    public static DiceRoll Parse(string expression)
    {
        var matches = GetMatches(expression);
        if (matches.Count == 0) throw new ArgumentException("Invalid expression", nameof(expression));

        var diceCollection = new DiceCollection();
        var modifierCollection = new ModifierCollection();

        foreach (Match match in matches)
        {
            var diceCount = match.Groups[1].Value;
            var diceSides = match.Groups[2].Value;
            if (string.IsNullOrEmpty(diceCount))
            {
                diceCollection.Add(new Die(int.Parse(diceSides)));
            }
            else
            {
                for (var i = 0; i < int.Parse(diceCount); i++)
                {
                    diceCollection.Add(new Die(int.Parse(diceSides)));
                }
            }
        }



        return new DiceRoll();
    }

    private static MatchCollection GetMatches(string expression)
    {
        var matches = System.Text.RegularExpressions.Regex.Matches(expression, Regex);
        return matches;
    }

}