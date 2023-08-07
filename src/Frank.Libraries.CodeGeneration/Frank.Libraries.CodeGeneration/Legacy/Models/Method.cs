using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Legacy.Models;

public record Method
{
    public Method(MethodSignature signature, List<CodeLine>? codeLines = null, List<Attribute>? attributes = null)
    {
        Signature = signature;
        CodeLines = codeLines.FallbackIfNull(new List<CodeLine>());
        Attributes = attributes.FallbackIfNull(new List<Attribute>());
    }

    public List<Attribute> Attributes { get; }
    public MethodSignature Signature { get; }
    public List<CodeLine> CodeLines { get; }

    public void AddCodeLine(CodeLine codeLine) => CodeLines.Add(codeLine);
    public void AddCodeLine(string code, char endOfLineCharacter = ';', int indents = 0) => CodeLines.Add(new CodeLine(code, indents, endOfLineCharacter));
    public void AddCodeLines(params CodeLine[] codeLines) => CodeLines.AddRange(codeLines);
    public void AddCodeLines(List<CodeLine> codeLines) => CodeLines.AddRange(codeLines);
    public void AddAttributes(params Attribute[] attributes) => Attributes.AddRange(attributes);

    /// <inheritdoc />
    public override string ToString() =>
        new StringBuilder()
            .AppendIf(Helpers.Indent(2) + string.Join($"\n{Helpers.Indent(2)}", Attributes.ToStrings()) + "\n", Attributes.Any())
            .AppendIndentedLine(2, Signature.ToString())
            .AppendIndentedLine(2, "{")
            .AppendIndentedLines(CodeLines.ToStrings()
                                          .ToList(), 2)
            .AppendIndentedLine(2, "}")
            .ToString();
}