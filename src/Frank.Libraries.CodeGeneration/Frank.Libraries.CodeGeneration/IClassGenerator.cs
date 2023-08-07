namespace Frank.Libraries.CodeGeneration;

public interface IClassGenerator
{
    ClassDeclarationSyntax GenerateClass(Type type, bool excludeObjectMethods = true);
}