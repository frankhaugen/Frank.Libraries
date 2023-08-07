namespace Frank.Libraries.CodeGeneration.Generators;

public class EnumMemberGenerator : IEnumMemberGenerator
{
    public EnumMemberDeclarationSyntax Generate(string name, IEnumerable<AttributeSyntax> attributes, IEnumerable<SyntaxTrivia> xmlComments)
    {
        return SyntaxFactory.EnumMemberDeclaration(name)
                            .WithAttributeLists(attributes.ToAttributeList())
                            .WithLeadingTrivia(xmlComments);
    }
}