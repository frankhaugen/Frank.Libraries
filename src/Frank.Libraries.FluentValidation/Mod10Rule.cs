

// ReSharper disable TailRecursiveCall

// ReSharper disable once CheckNamespace
namespace FluentValidation;

/// <summary>
///     Fluent Validation rules for Mod 10
/// </summary>
public static class Mod10Rule
{
    /// <summary>
    ///     Rule to validate if the <see cref="short">short</see> is a valid number according to the Mod10 algorithm/>
    /// </summary>
    /// <param name="ruleBuilder"></param>
    /// <returns></returns>
    public static IRuleBuilder<short, short> IsMod10(this IRuleBuilder<short, short> ruleBuilder) =>
        ruleBuilder
            .Must(x => x > 0)
            .WithMessage("Is a non-positive number")
            .Must(x => GetMod10(x.ToString())
                      .IsValid)
            .WithMessage("Is not valid according to Mod 10");

    /// <summary>
    ///     Rule to validate if the <see cref="long">long</see> is a valid number according to the Mod10 algorithm/>
    /// </summary>
    /// <param name="ruleBuilder"></param>
    /// <returns></returns>
    public static IRuleBuilder<int, int> IsMod10(this IRuleBuilder<int, int> ruleBuilder) =>
        ruleBuilder.Custom((value, context) =>
        {
            if (value < 1)
            {
                context.AddFailure(nameof(value), "Is a non-positive number");
            }
            else if (!GetMod10(value.ToString())
                         .IsValid)
            {
                context.AddFailure(nameof(value), "Is not valid according to Mod 10");
            }
        });

    /// <summary>
    ///     Rule to validate if the <see cref="long">long</see> is a valid number according to the Mod10 algorithm/>
    /// </summary>
    /// <param name="ruleBuilder"></param>
    /// <returns></returns>
    public static IRuleBuilder<long, long> IsMod10(this IRuleBuilder<long, long> ruleBuilder) =>
        ruleBuilder.Custom((value, context) =>
        {
            if (value < 1)
            {
                context.AddFailure(nameof(value), "Is a non-positive number");
            }
            else if (!GetMod10(value.ToString())
                         .IsValid)
            {
                context.AddFailure(nameof(value), "Is not valid according to Mod 10");
            }
        });

    /// <summary>
    ///     Rule to validate if the <see cref="string">string</see> is a valid number according to the Mod10 algorithm/>
    /// </summary>
    /// <param name="ruleBuilder"></param>
    /// <returns></returns>
    public static IRuleBuilder<string, string> IsMod10(this IRuleBuilder<string, string> ruleBuilder) =>
        ruleBuilder.Custom((value, context) =>
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                context.AddFailure(nameof(value), "Is null, empty, or whitespace");
            }
            else if (!GetMod10(value)
                         .IsValid)
            {
                context.AddFailure(nameof(value), "Is not valid according to Mod 10");
            }
        });

    //USAGE: Mod10("502114008060") --> 8. The controlnumber is 8.
    /// <summary>
    ///     Extracts the control number and checks if it's valid
    /// </summary>
    /// <param name="value"></param>
    /// <example>"502114008060" returns (true, 8)</example>
    /// <returns>
    ///     <see cref="ValueTuple">ValueTyple<bool, int>()</bool>)</see>
    /// </returns>
    public static (bool IsValid, int ControlNumber) GetMod10(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return (false, 0);
        }

        var isValid = false;
        var controlNumber = 0;

        foreach (var number in value.Reverse())
        {
            var intNumber = int.Parse(number.ToString());
            int sum;
            if (isValid)
            {
                sum = intNumber;
            }
            else
            {
                sum = 2 * intNumber;
            }

            if (sum > 9)
            {
                sum = sum % 10 + 1;
            }

            isValid = !isValid;
            controlNumber += sum;
        }

        var calculation = (10 - controlNumber % 10) % 10;

        return (calculation != 0, calculation == 0
                    ? 0
                    : 10 - controlNumber % 10);
    }
}