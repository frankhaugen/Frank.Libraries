namespace Frank.Libraries.CodeGeneration.Generators
{
    public class FluentCalculatorGenerator
    {
        public string GenerateSimple(string returnType, string name, string sourceType, string valueType, string operatorValue) => $"public static {returnType} {name}(this {sourceType} source, {valueType} value) => source {operatorValue} value;";

        //public List<string> GenerateSimples()
        //{
        //    List < (ReturnType: string, Name: string) >
        //}
    }
}