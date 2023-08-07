namespace Frank.Libraries.CodeGeneration.Generators;

public interface IClassGenerator
{
    ClassDeclarationSyntax GenerateClass(Type type, bool excludeObjectMethods = true);
}