namespace Frank.Libraries.Gaming.Starfinder.Common
{
    public class DiceRoller
    {
        public static int RollDice(params (int, Dice)[] rolls)
        {
            var result = 1;
            foreach (var (item1, item2) in rolls)
            {
                var rollResult = new Roll(item1, item2);
                result += rollResult.GetResult();
            }

            return result;
        }
    }
}