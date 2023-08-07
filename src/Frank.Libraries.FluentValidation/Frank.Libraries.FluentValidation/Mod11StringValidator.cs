using FluentValidation;

namespace Frank.Libraries.FluentValidation;

/// <summary>
///     Validates if a <see cref="string" /> is Mod 10 compliant
/// </summary>
public class Mod11StringValidator : AbstractValidator<string>
{
    /// <inheritdoc />
    public Mod11StringValidator() =>
        RuleFor(x => x)
            .IsMod11();
}