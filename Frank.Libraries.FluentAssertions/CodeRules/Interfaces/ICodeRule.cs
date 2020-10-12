namespace Frank.Libraries.Testing.CodeRules.Interfaces
{
    public interface ICodeRule
    {
        public int TextLines { get; }
        public int CodeLines { get; }
        public bool IgnoreComments { get; }
    }
}
