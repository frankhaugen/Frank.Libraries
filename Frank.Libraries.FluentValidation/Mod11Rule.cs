using System;
using System.Linq;

// ReSharper disable TailRecursiveCall

// ReSharper disable once CheckNamespace
namespace FluentValidation
{
    /// <summary>
    /// Fluent Validation rules for Mod 10
    /// </summary>
    public static class Mod11Rule
    {
        /// <summary>
        /// Rule to validate if the <see cref="short">short</see> is a valid number according to the Mod10 algorithm/>
        /// </summary>
        /// <param name="ruleBuilder"></param>
        /// <returns></returns>
        public static IRuleBuilder<short, short> IsMod11(this IRuleBuilder<short, short> ruleBuilder)
        {
            return ruleBuilder
                .Must(x => x > 0)
                .WithMessage("Is a non-positive number")
                .Must(x => GetMod11(x.ToString()).IsValid)
                .WithMessage("Is not valid according to Mod 10");
        }

        /// <summary>
        /// Rule to validate if the <see cref="long">long</see> is a valid number according to the Mod10 algorithm/>
        /// </summary>
        /// <param name="ruleBuilder"></param>
        /// <returns></returns>
        public static IRuleBuilder<int, int> IsMod11(this IRuleBuilder<int, int> ruleBuilder)
        {
            return ruleBuilder.Custom((value, context) =>
            {
                if (value < 1)
                    context.AddFailure(nameof(value), "Is a non-positive number");
                else if (!GetMod11(value.ToString()).IsValid)
                    context.AddFailure(nameof(value), "Is not valid according to Mod 10");
            });
        }

        /// <summary>
        /// Rule to validate if the <see cref="long">long</see> is a valid number according to the Mod10 algorithm/>
        /// </summary>
        /// <param name="ruleBuilder"></param>
        /// <returns></returns>
        public static IRuleBuilder<long, long> IsMod11(this IRuleBuilder<long, long> ruleBuilder)
        {
            return ruleBuilder.Custom((value, context) =>
            {
                if (value < 1)
                    context.AddFailure(nameof(value), "Is a non-positive number");
                else if (!GetMod11(value.ToString()).IsValid)
                    context.AddFailure(nameof(value), "Is not valid according to Mod 10");
            });
        }

        /// <summary>
        /// Rule to validate if the <see cref="string">string</see> is a valid number according to the Mod10 algorithm/>
        /// </summary>
        /// <param name="ruleBuilder"></param>
        /// <returns></returns>
        public static IRuleBuilder<string, string> IsMod11(this IRuleBuilder<string, string> ruleBuilder)
        {
            return ruleBuilder.Custom((value, context) =>
            {
                if (string.IsNullOrWhiteSpace(value))
                    context.AddFailure(nameof(value), "Is null, empty, or whitespace");
                else if (!GetMod11(value).IsValid)
                    context.AddFailure(nameof(value), "Is not valid according to Mod 10");
            });
        }

        //USAGE: Mod10("502114008060") --> 8. The controlnumber is 8.
        /// <summary>
        /// Extracts the control number and checks if it's valid
        /// </summary>
        /// <param name="value"></param>
        /// <example>"502114008060" returns (true, 8)</example>
        /// <returns><see cref="ValueTuple">ValueTyple<bool, int>()</bool>)</see></returns>
        public static (bool IsValid, int ControlNumber) GetMod11(string? value)
        {
            // Fjern whitespace og punktum fra kontonummer (enkelte liker å formatere kontonummer med 1234.56.78903)
            value = value?.Replace(" ", "");
            value = value?.Replace(".", "");
            // Skal inneholde 11 siffer og kun tall
            if (value?.Length != 11 || !int.TryParse(value, out var _))
            {
                return (false, 0);
            }

            var sisteSiffer = (int)char.GetNumericValue(value.Last());

            return (GetCheckDigit(value) == sisteSiffer, sisteSiffer);

        }

        private static int GetCheckDigit(string number)
        {
            int lastIndex = number.Length - 1;
            int sum = 0;

            for (int i = 0; i < lastIndex; i++)
            {
                sum += (int)char.GetNumericValue(number.ElementAt(i)) * GetWeightNumber(i);
            }

            int remainder = sum % 11;

            return GetCheckDigitFromRemainder(remainder);
        }

        private static int GetWeightNumber(int i)
        {
            return 7 - (i + 2) % 6;
        }


        private static int GetCheckDigitFromRemainder(int remainder)
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
}
