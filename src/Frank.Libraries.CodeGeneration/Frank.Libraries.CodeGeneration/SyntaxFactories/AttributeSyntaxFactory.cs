namespace Frank.Libraries.CodeGeneration.SyntaxFactories;

public static class AttributeSyntaxFactory
{
    public static AttributeSyntax Attribute(Type type, string value) => SyntaxFactory.Attribute(
        SyntaxFactory.ParseName(type.Name),
        SyntaxFactory.ParseAttributeArgumentList($"(\"{value}\")"));

    public static AttributeSyntax Attribute(string name, string value) => SyntaxFactory.Attribute(
        SyntaxFactory.ParseName(name),
        SyntaxFactory.ParseAttributeArgumentList($"(\"{value}\")"));
}

public static class ExtensionMethodSyntaxFactory
{
    public static MethodDeclarationSyntax GenerateMethod(string methodName, string parameterType, string returnType, params StatementSyntax[] body) =>
        SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName(returnType), methodName)
                     .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                     .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("this source")).WithType(SyntaxFactory.ParseTypeName(parameterType)))
                     .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("value")).WithType(SyntaxFactory.ParseTypeName(parameterType)))
                     .WithBody(SyntaxFactory.Block(body));
}