namespace Frank.Libraries.CodeGeneration.Generators;

public interface IMethodGenerator
{
    MethodDeclarationSyntax GenerateMethod(MethodInfo method, string suffix = "");
}