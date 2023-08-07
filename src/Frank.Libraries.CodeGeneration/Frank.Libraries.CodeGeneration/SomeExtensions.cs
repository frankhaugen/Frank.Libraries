namespace Frank.Libraries.CodeGeneration;

public static class SomeExtensions
{
    public static SyntaxList<AttributeListSyntax> ToAttributeList(this IEnumerable<AttributeSyntax> source) => SyntaxFactory.List(source.Select(x => SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(x))));
}