namespace Frank.Libraries.CodeGeneration
{
    public interface IGenerator
    {
        string Generate(string namespaceName, string className);
    }
}