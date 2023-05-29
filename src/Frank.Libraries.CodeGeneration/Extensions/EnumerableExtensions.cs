namespace Frank.Libraries.CodeGeneration.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<string> ToStrings<T>(this IEnumerable<T> source)
    {
        var output = new List<string>();

        foreach (var value in source)
        {
            output.TryAdd(value!.ToString());
        }

        return output;
    }

    public static IEnumerable<T> DoForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        if (source == null || !source.Any())
        {
            return source;
        }

        foreach (var value in source)
        {
            if (value == null)
            {
                continue;
            }

            action.Invoke(value);
        }

        return source;
    }
}

public static class StatementSyntaxExtensions
{
    public static void AddComment(this List<StatementSyntax> source, string comment)
    {
        var statement = SyntaxFactory.ParseStatement("").WithLeadingTrivia(SyntaxFactory.Comment(comment));
        source.Add(statement);
    }

    public static void AddLineBreak(this List<StatementSyntax> source, int number = 1)
    {
        for (int i = 0; i < number; i++)
        {
            var comment = SyntaxFactory.Comment(" ");
            var statement = SyntaxFactory.ParseStatement("").WithLeadingTrivia(comment);
            source.Add(statement);
        }
    }
}