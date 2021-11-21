using System;
using FluentValidation;

namespace Frank.Libraries.FluentValidation
{
    public class MethodExecutionValidator : AbstractValidator<Action>
    {
        public MethodExecutionValidator()
        {
            RuleFor(x => x)
                .ThrowsNot();
        }
    }
}