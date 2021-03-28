using System;
using System.Text;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Models
{
    public record Argument
    {
        public readonly Type Type;
        public readonly bool IsNullable;
        public readonly string Name;
        public readonly bool IsParams;
        public readonly bool HasDefaultValue;
        public readonly string DefaultValue;

        public Argument(Type type, string? name = null, bool isNullable = false, bool isParams = false, string defaultValue = "")
        {
            Type = type;
            Name = name.FallbackIfNull(nameof(Type).ToCamelcase());
            IsParams = isParams;
            HasDefaultValue = !string.IsNullOrWhiteSpace(defaultValue);
            DefaultValue = defaultValue;
            IsNullable = isNullable;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return new StringBuilder()
                .AppendIf("params ", IsParams)
                .Append(Type.FullName.FallbackIfNull(Type.Name))
                .AppendIf("? ", IsNullable, " ")
                .Append(Name)
                .AppendIf(" = ", HasDefaultValue)
                .AppendIf(DefaultValue, HasDefaultValue)
                .ToString();
        }
    }
}