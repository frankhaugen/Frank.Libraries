using System;
using System.Text;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Models;

public record Argument
{
    public readonly string DefaultValue;
    public readonly bool HasDefaultValue;
    public readonly bool IsExtension;
    public readonly bool IsNullable;
    public readonly bool IsParams;
    public readonly string Name;
    public readonly Type Type;

    public Argument(Type type, string? name = null, bool isNullable = false, bool isParams = false, bool isExtension = false, string defaultValue = "")
    {
        Type = type;
        Name = name.FallbackIfNull(nameof(Type)
                                       .ToCamelCase());
        IsParams = isParams;
        HasDefaultValue = !string.IsNullOrWhiteSpace(defaultValue);
        DefaultValue = defaultValue;
        IsNullable = isNullable;
        IsExtension = isExtension;
    }

    /// <inheritdoc />
    public override string ToString() =>
        new StringBuilder()
            .AppendIf("this ", IsExtension)
            .AppendIf("params ", IsParams)
            .Append(Type.FullName.FallbackIfNull(Type.Name))
            .AppendIf("? ", IsNullable, " ")
            .Append(Name)
            .AppendIf(" = ", HasDefaultValue)
            .AppendIf(DefaultValue, HasDefaultValue)
            .ToString();
}