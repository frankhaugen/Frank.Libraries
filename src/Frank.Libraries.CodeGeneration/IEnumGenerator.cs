namespace Frank.Libraries.CodeGeneration.Generators;

public interface IEnumGenerator
{
    EnumDeclarationSyntax Generate(string name);
}

public interface IAttributeGenerator
{
    ClassDeclarationSyntax Generate(string name, IDictionary<string, Type> properties);
}

public class CultureInfoNameAttributeGenerator : IAttributeGenerator
{
    public ClassDeclarationSyntax Generate(string name, IDictionary<string, Type> properties)
    {
        var classDeclaration = SyntaxFactory.ClassDeclaration(name)
                                            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                                            .AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName("Attribute")))
                                            .AddMembers(properties.Select(x => SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(x.Value.Name), x.Key)
                                                                                      .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                                                                                      .AddAccessorListAccessors(SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)))
                                                                                      .AddAccessorListAccessors(SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))))
                                                                   .ToArray());
        return classDeclaration;
    }
}