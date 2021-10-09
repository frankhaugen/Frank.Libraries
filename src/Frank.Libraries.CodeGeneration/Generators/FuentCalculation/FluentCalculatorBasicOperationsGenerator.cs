using System.Collections.Generic;
using CodegenCS;

namespace Frank.Libraries.CodeGeneration.Generators.FuentCalculation
{
    public static class FluentCalculatorBasicOperationsGenerator
    {
        public static string Generate(string namespaceName = "Frank.Libraries.Calculators.FluentCalculation", string className = "FluentCalculatorBasicOperations")
        {
            var w = new CodegenTextWriter();

            var typesOverride = new List<string>
            {
                "int",
                "short",
                "long"
            };

            w.WithCurlyBraces($"namespace {namespaceName}", () =>
            {
                w.WithCurlyBraces($"public static class {className}", () =>
                {
                    foreach (var @operator in Operators)
                    {
                        w.WriteLine($"// {@operator.Key} ");
                        foreach (var type in Types)
                        {
                            var returnType = type;
                            if (@operator.Key == Operator.Divide && typesOverride.Contains(type)) returnType = "decimal";
                            else
                            {

                            }
                            w.WriteLine($"public static {returnType} {@operator.Key}(this {type} source, {type} value) => ({returnType}) (source {@operator.Value} value);");
                        }
                        w.WriteLine(" ");
                    }
                });
            });

            return w.GetContents();
        }

        private static List<string> Types => new()
        {
            "int",
            //types.Add("uint");
            "short",
            //types.Add("ushort");
            "long",
            //types.Add("ulong");
            "float",
            "double",
            "decimal"
        };

        private static Dictionary<Operator, string> Operators => new()
        {
            { Operator.Add, "+" },
            { Operator.Subtract, "-" },
            { Operator.Multiply, "*" },
            { Operator.Divide, "/" }
        };

        private enum Operator
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            PowerOf,

        }
    }
}