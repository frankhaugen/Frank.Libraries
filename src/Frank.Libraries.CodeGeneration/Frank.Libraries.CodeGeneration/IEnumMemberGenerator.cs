namespace Frank.Libraries.CodeGeneration;

public interface IEnumMemberGenerator
{
    EnumMemberDeclarationSyntax Generate(string name, IEnumerable<AttributeSyntax> attributes, IEnumerable<SyntaxTrivia> xmlComments);
}