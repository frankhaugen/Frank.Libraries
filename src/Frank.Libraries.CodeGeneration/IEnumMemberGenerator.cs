namespace Frank.Libraries.CodeGeneration.Generators;

public interface IEnumMemberGenerator
{
    EnumMemberDeclarationSyntax Generate(string name, IEnumerable<AttributeSyntax> attributes, IEnumerable<SyntaxTrivia> xmlComments);
}