using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Frank.Libraries.Tests.TestingInfrastructure.Generators
{
    public static class KidNumberGenerator
    {
        public static string Get() => GetValidKid();

        private static string GetValidKid()
        {
            var kid = "";
            var run = true;
            while (run)
            {
                kid = CreateKid();
                run = ValidateKid(kid);
            }

            return kid;
        }

        private static string CreateKid()
        {
            var stringBuilder = new StringBuilder();
            var length = RandomKidLength;

            for (var i = 0; i < length; i++)
            {
                stringBuilder.Append(RandomDigit);
            }

            return stringBuilder.ToString();
        }

        private static int RandomDigit => RandomNumberGenerator.GetInt32(0, 10);
        private static int RandomKidLength => RandomNumberGenerator.GetInt32(2, 25);

        private static bool ValidateKid(string kid) => Mod10(kid) != 0;

        private static int Mod10(string kid)
        {
            var isOne = false;
            var controlNumber = 0;
            foreach (var number in kid.Reverse())
            {
                var intNumber = int.Parse(number.ToString());
                var sum = isOne
                    ? intNumber
                    : 2 * intNumber;
                if (sum > 9)
                {
                    sum = (sum % 10) + 1;
                }

                isOne = !isOne;
                controlNumber += sum;
            }

            return
                (10 - (controlNumber % 10))
                % 10
                == 0
                    ? 0
                    : 10 - (controlNumber % 10);
        }
    }
}