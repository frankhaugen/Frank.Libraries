using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Legacy.Models;

public record Attribute
{
    public readonly string Name;

    public Attribute(Type type) => Name = type.Name.Replace("Attribute", "");

    public Attribute(string type) => Name = type;

    /// <inheritdoc />
    public override string ToString() => new StringBuilder().AppendSurroundedBy('[', Name, ']')
                                                            .ToString();
}