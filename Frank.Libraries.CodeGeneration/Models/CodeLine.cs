namespace Frank.Libraries.CodeGeneration.Models
{
    public record CodeLine
    {
        public readonly string Code;
        public readonly char EndOfLineCharacter;
        public readonly int Indents;

        public CodeLine(string code, int indents = 0, char endOfLineCharacter = ';')
        {
            Code = code;
            EndOfLineCharacter = endOfLineCharacter;
            Indents = indents;
        }

        /// <inheritdoc/>
        public override string ToString() => $"{Helpers.Indent(Indents)}{Code}{EndOfLineCharacter}";
    }

    public static class Helpers
    {
        public static string Indent(int count = 1)
        {
            var output = "";
            for (int i = 0; i < count; i++)
            {
                output += "    ";
            }

            return output;
        }
    }
}