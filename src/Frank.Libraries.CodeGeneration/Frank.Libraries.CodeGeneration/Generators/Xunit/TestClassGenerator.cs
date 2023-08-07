using Frank.Libraries.CodeGeneration.Extensions;
using Frank.Libraries.CodeGeneration.Generators;

namespace Frank.Libraries.CodeGeneration;

public class TestClassGenerator : IClassGenerator
{
    private readonly IMethodGenerator _methodGenerator;
    private readonly List<string> _ignoreMethods = new List<string> { "ToString", "Equals", "GetHashCode", "GetType" };

    public TestClassGenerator(IMethodGenerator methodGenerator)
    {
        _methodGenerator = methodGenerator;
    }

    public ClassDeclarationSyntax GenerateClass(Type type, bool excludeObjectMethods = true)
    {
        var methods = type
            .GetMethods()
            .OrderBy(x => x.Name)
            .Where(x => !x.IsBaseMethod())
            .Where(x => !excludeObjectMethods || !_ignoreMethods.Contains(x.Name))
            .Where(x => !x.IsPropertyMethod())
            .Select(x => _methodGenerator.GenerateMethod(x))
            .ToArray()
            ;

        var usingDirectives = GetUsingDirectives(type);

        var className = type.Name + "Tests";
        return SyntaxFactory.ClassDeclaration(className)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddMembers(GetPrivateFields(type))
            .AddMembers(GetConstructorDeclaration(type.GetConstructors().First(), className))
            .WithLeadingTrivia(SyntaxFactory.Trivia(SyntaxFactory.DocumentationCommentTrivia(SyntaxKind.SingleLineDocumentationCommentTrivia)))
            .AddMembers(methods)
            .NormalizeWhitespace();
    }

    private IEnumerable<StatementSyntax> GetAssertStatements(MethodInfo method)
    {
        var statements = new List<StatementSyntax>();
        statements.Add(SyntaxFactory.ParseStatement("_outputHelper.WriteLine(result);"));
        statements.Add(SyntaxFactory.ParseStatement("result.ToString().Should().NotBeNullOrEmpty();"));
        return statements;
    }

    private ConstructorDeclarationSyntax GetConstructorDeclaration(ConstructorInfo constructor, string testClassName)
    {
        var parameters = constructor.GetParameters().Select(p => SyntaxFactory.Parameter(SyntaxFactory.Identifier(p.Name?.ToCamelcase())).WithType(SyntaxFactory.ParseTypeName(p.ParameterType.FriendlyName())));
        var statements = new List<StatementSyntax>();
        foreach (var parameter in parameters)
        {
            statements.Add(SyntaxFactory.ParseStatement($"{parameter.Identifier} = Substitute.For<{parameter.Type}>();"));
        }
        var constructorNode = SyntaxFactory.ConstructorDeclaration(testClassName)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .WithParameterList(SyntaxFactory.ParseParameterList($"{testClassName}(ITestOutputHelper outputHelper)"))
            .WithBody(SyntaxFactory.Block(statements))
        .WithLeadingTrivia(SyntaxFactory.Trivia(SyntaxFactory.DocumentationCommentTrivia(SyntaxKind.SingleLineDocumentationCommentTrivia))); // Updated line
        return constructorNode;
    }

    private IEnumerable<FieldDeclarationSyntax> GetPrivateFields(ConstructorInfo constructor)
    {
        var fields = new List<FieldDeclarationSyntax>();

        fields.Add(CreateOutputHelperFieldDeclaration());

        foreach (var argument in constructor.GetParameters())
        {
            fields.Add(CreateFieldDeclaration(argument));
        }

        return fields;
    }

    MemberDeclarationSyntax[] GetPrivateFields(Type type)
    {
        return GetPrivateFields(type.GetConstructors());
    }

    FieldDeclarationSyntax[] GetPrivateFields(ConstructorInfo[] constructorInfos)
    {
        return constructorInfos.SelectMany(constructor => GetPrivateFields(constructor)).ToArray();
    }

    private FieldDeclarationSyntax CreateFieldDeclaration(ParameterInfo parameter)
    {
        return SyntaxFactory.FieldDeclaration(
            SyntaxFactory.VariableDeclaration(SyntaxFactory.IdentifierName(parameter.ParameterType.Name))
            .WithVariables(SyntaxFactory.SingletonSeparatedList(SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier("_" + parameter.Name)))))
            .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PrivateKeyword), SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword)));
    }

    private FieldDeclarationSyntax CreateOutputHelperFieldDeclaration()
    {
        return SyntaxFactory.FieldDeclaration(
            SyntaxFactory.VariableDeclaration(SyntaxFactory.IdentifierName("ITestOutputHelper"))
            .WithVariables(SyntaxFactory.SingletonSeparatedList(SyntaxFactory.VariableDeclarator(SyntaxFactory.Identifier("_outputHelper")))))
            .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PrivateKeyword), SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword)));
    }

    private IEnumerable<UsingDirectiveSyntax> GetUsingDirectives(Type type)
    {
        return type.GetReferencedNamespaces().Select(ns => SyntaxFactory.UsingDirective(SyntaxFactory.ParseName(ns)));
    }
}