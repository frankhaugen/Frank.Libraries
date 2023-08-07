namespace Frank.Libraries.CodeGeneration;

public interface IMethodGenerator
{
    MethodDeclarationSyntax GenerateMethod(MethodInfo method, string suffix = "");
}