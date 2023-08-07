using FluentValidation;

namespace Frank.Libraries.FluentValidation;

/// <summary>
///     Validates if a <see cref="short" /> is Mod 10 compliant
/// </summary>
public class Mod10ShortValidator : AbstractValidator<short>
{
    /// <inheritdoc />
    public Mod10ShortValidator() =>
        RuleFor(x => x)
            .IsMod10();
}