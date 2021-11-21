using System;
using System.Text;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Models
{
    public record Attribute
    {
        public readonly string Name;

        public Attribute(Type type)
        {
            Name = type.Name.Replace("Attribute", "");
        }

        /// <inheritdoc/>
        public override string ToString() => new StringBuilder().AppendSurroundedBy('[', Name, ']')
                                                                .ToString();
    }
}