namespace Frank.Libraries.CodeGeneration.Generators;

public interface IGenerator
{
    string Generate(string namespaceName, string className);
}