namespace Frank.Libraries.CodeGeneration.SyntaxFactories;

public static class XmlDocSyntaxFactory
{
    public static SyntaxTrivia SingleLineSummaryComment(string summary) => SyntaxFactory.Comment($"/// <summary>{summary}</summary>\n");

    public static SyntaxTrivia SingleLineRemarksComment(string remarks) => SyntaxFactory.Comment($"/// <remarks>{remarks}</remarks>\n");

    public static SyntaxTriviaList MultiLineSummaryComment(IEnumerable<string> summary)
    {
        var triviaList = SyntaxFactory.TriviaList(SyntaxFactory.Comment($"/// <summary>\n"));
        foreach (var line in summary) triviaList.Add(SyntaxFactory.Comment($"/// {line}\n"));
        triviaList.Add(SyntaxFactory.Comment($"/// </summary>\n"));
        return triviaList;
    }
}