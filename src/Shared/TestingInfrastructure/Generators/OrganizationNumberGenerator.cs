using System.Security.Cryptography;
using System.Text;

namespace TestingInfrastructure.Generators;

public static class OrganizationNumberGenerator
{
    private static int RandomDigit => RandomNumberGenerator.GetInt32(0, 10);

    public static string Get()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("9");

        var length = 8;

        for (var i = 0; i < length; i++)
        {
            stringBuilder.Append(RandomDigit);
        }

        return stringBuilder.ToString();
    }
}