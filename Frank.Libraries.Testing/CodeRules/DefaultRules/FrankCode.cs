using Frank.Libraries.Testing.CodeRules.Interfaces;

namespace Frank.Libraries.Testing.CodeRules.DefaultRules
{
    /// <summary>
    /// A default rule for the Frank Code standard
    /// </summary>
    public class FrankCode : ICodeRule
    {
        /// <inheritdoc />
        public int TextLines { get; } = 150;

        /// <inheritdoc />
        public int CodeLines { get; } = 50;

        /// <inheritdoc />
        public bool IgnoreComments { get; }
    }
}
