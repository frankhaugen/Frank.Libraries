using FluentValidation;

namespace Frank.Libraries.FluentValidation
{
    /// <summary>
    /// Validates if a <see cref="string"/> is Mod 10 compliant
    /// </summary>
    public class Mod10StringValidator : AbstractValidator<string>
    {
        /// <inheritdoc />
        public Mod10StringValidator()
        {
            RuleFor(x => x)
                .IsMod10();
        }
    }
}