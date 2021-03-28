using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Models
{
    public record MethodSignature
    {
        public readonly Type? ReturnType;
        public readonly string Name;
        public readonly bool IsAsync;
        public readonly bool IsNullable;
        public readonly List<Argument>? Arguments;

        public MethodSignature(string name, Type? returnType = null, List<Argument>? arguments = null, bool isAsync = false, bool isNullable = false)
        {
            ReturnType = returnType;
            Name = name;
            IsAsync = isAsync;
            IsNullable = isNullable;
            Arguments = arguments;
        }

        /// <inheritdoc/>
        public override string ToString() => new StringBuilder()
            .AppendWithTrailingSpace("public")
            .AppendIf("async ", IsAsync)
            .AppendIf(ReturnType?.Name ?? string.Empty, ReturnType != null, "void")
            .AppendIf("? ", IsNullable, " ")
            .Append(Name)
            .AppendSurroundedBy('(', string.Join(", ", Arguments.FallbackIfNull(new List<Argument>()).Select(x => x.ToString())), ')')
            .ToString();
    }
}