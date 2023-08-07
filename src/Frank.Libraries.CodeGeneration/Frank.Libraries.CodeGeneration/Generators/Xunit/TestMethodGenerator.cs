using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Generators;

public class TestMethodGenerator : IMethodGenerator
{
    public MethodDeclarationSyntax GenerateMethod(MethodInfo method, string suffix = "")
    {
        var returnType = method.GetReturnStatement();

        var statements = new List<StatementSyntax>();

        statements.AddComment("// Arrange");
        statements.AddRange(GetArrangeStatements(method));
        statements.AddLineBreak();

        statements.AddComment("// Act");
        statements.AddRange(GetActStatements(method));
        statements.AddLineBreak();

        statements.AddComment("// Assert");
        statements.AddRange(GetAssertStatements(method));

        var methodBody = SyntaxFactory.Block(statements);
        var methodNode = SyntaxFactory.MethodDeclaration(returnType, $"{method.Name}Test{suffix}")
                                      .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                                      .AddAttributeLists(SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(
                                                                                         SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("Fact"))
                                                                                     )))
                                      //.WithParameterList(methodParameters)
                                      .WithBody(methodBody);

        return methodNode.NormalizeWhitespace();
    }

    private IEnumerable<StatementSyntax> GetAssertStatements(MethodInfo method)
    {
        var statements = new List<StatementSyntax>();
        statements.Add(SyntaxFactory.ParseStatement("_outputHelper.WriteLine(result);"));
        statements.Add(SyntaxFactory.ParseStatement("result.ToString().Should().NotBeNullOrEmpty();"));
        return statements;
    }

    private IEnumerable<StatementSyntax> GetActStatements(MethodInfo method)
    {
        var statements = new List<StatementSyntax>();
        var methodType = method.GetMethodVariant();
        var methodParameters = method.GetParameters();

        statements.Add(SyntaxFactory.ParseStatement("// Act"));

        var awaitPrefix = "";
        if (method.IsAsync())
        {
            awaitPrefix = "await ";
        }

        ExpressionSyntax invocationExpression;
        switch (methodType)
        {
            case MethodVariant.Instance:
                invocationExpression = SyntaxFactory.ParseExpression($"_sut.{method.Name}({string.Join(", ", methodParameters.Where(x => !x.HasDefaultValue).Select(x => x.Name))})");
                break;
            case MethodVariant.Extension:
                invocationExpression = SyntaxFactory.ParseExpression($"{method.Name}({string.Join(", ", methodParameters.Select(x => x.Name))})");
                break;
            case MethodVariant.Static:
                invocationExpression = SyntaxFactory.ParseExpression($"{method.DeclaringType?.GetFriendlyName()}.{method.Name}({string.Join(", ", methodParameters.Select(x => x.Name))})");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        var resultStatement = SyntaxFactory.LocalDeclarationStatement
        (
            SyntaxFactory.VariableDeclaration
                         (
                             SyntaxFactory.IdentifierName("var")
                         )
                         .WithTrailingTrivia(SyntaxFactory.ParseTrailingTrivia(" "))
                         .WithVariables
                         (
                             SyntaxFactory.SingletonSeparatedList<VariableDeclaratorSyntax>
                             (
                                 SyntaxFactory.VariableDeclarator
                                              (
                                                  SyntaxFactory.Identifier("result")
                                              )
                                              .WithTrailingTrivia(SyntaxFactory.ParseTrailingTrivia(" "))
                                              .WithInitializer
                                              (
                                                  SyntaxFactory.EqualsValueClause
                                                  (
                                                      invocationExpression
                                                  )
                                              )
                             )
                         )
        );
        statements.Add(resultStatement);

        return statements;
    }

    private IEnumerable<StatementSyntax> GetArrangeStatements(MethodInfo method)
    {
        var statements = new List<StatementSyntax>();
        var methodType = method.GetMethodVariant();
        var methodParameters = method.GetParameters();
        statements.Add(SyntaxFactory.ParseStatement("// Arrange"));

        if (methodType == MethodVariant.Instance)
        {
            statements.Add(SyntaxFactory.ParseStatement($"var _sut = new {method.DeclaringType}();"));
        }

        if (methodType == MethodVariant.Extension)
        {
            var thisParameter = methodParameters.First();
            methodParameters.RemoveAt(0);
            statements.Add(SyntaxFactory.ParseStatement($"var {thisParameter.Name.ToCamelcase()} = default({thisParameter.ParameterType.Name});"));
        }

        foreach (var param in methodParameters)
        {
            statements.Add(SyntaxFactory.ParseStatement($"var {param.Name?.ToCamelcase()} = default({param.ParameterType.Name});"));
        }

        return statements;
    }
}