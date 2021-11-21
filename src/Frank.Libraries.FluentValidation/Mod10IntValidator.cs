using FluentValidation;

namespace Frank.Libraries.FluentValidation
{
    /// <summary>
    /// Validates if a <see cref="int"/> is Mod 10 compliant
    /// </summary>
    public class Mod10IntValidator : AbstractValidator<int>
    {
        /// <inheritdoc />
        public Mod10IntValidator()
        {
            RuleFor(x => x)
                .IsMod10();
        }
    }
}