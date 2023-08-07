using FluentValidation;

namespace Frank.Libraries.FluentValidation;

/// <summary>
///     Validates if a <see cref="long" /> is Mod 10 compliant
/// </summary>
public class Mod10LongValidator : AbstractValidator<long>
{
    /// <inheritdoc />
    public Mod10LongValidator() =>
        RuleFor(x => x)
            .IsMod10();
}