﻿using System.Security.Cryptography;
using System.Text;

namespace TestingInfrastructure.Generators;

public static class AccountNumberGenerator
{
    private static int RandomDigit => RandomNumberGenerator.GetInt32(0, 10);
    public static string Get() => GetValidKid();

    private static string GetValidKid()
    {
        var kid = "";
        var run = true;
        while (run)
        {
            kid = CreateKid();
            run = gyldigKontonummer(kid);
        }

        return kid;
    }

    private static string CreateKid()
    {
        var stringBuilder = new StringBuilder();
        var length = 11;

        for (var i = 0; i < length; i++)
        {
            stringBuilder.Append(RandomDigit);
        }

        return stringBuilder.ToString();
    }

    private static bool gyldigKontonummer(string kontonr)
    {
        if (kontonr.Length != 11 || !int.TryParse(kontonr, out _))
        {
            return false;
        }

        int sisteSiffer = kontonr[^1];

        return getCheckDigit(kontonr) == sisteSiffer;
    }

    private static int getCheckDigit(string number)
    {
        var lastIndex = number.Length - 1;
        var sum = 0;

        for (var i = 0; i < lastIndex; i++)
        {
            sum += number[i] * getWeightNumber(i);
        }

        var remainder = sum % 11;

        return getCheckDigitFromRemainder(remainder);
    }

    private static int getWeightNumber(int i) => 7 - (i + 2) % 6;

    private static int getCheckDigitFromRemainder(int remainder)
    {
        switch (remainder)
        {
            case 0:
                return 0;

            default:
                return 11 - remainder;
        }
    }
}