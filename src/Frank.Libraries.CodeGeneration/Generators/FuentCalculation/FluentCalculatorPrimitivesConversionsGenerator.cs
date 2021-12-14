using System;
using System.Collections.Generic;
using System.Linq;
using CodegenCS;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Generators.FuentCalculation
{
    public class FluentCalculatorPrimitivesConversionsGenerator : IGenerator
    {
        public string Generate(string namespaceName, string className)
        {
            var writer = new CodegenTextWriter();
            writer.WriteLine($"using System;");
            writer.WriteLine($" ");
            writer.WriteLine($"namespace {namespaceName};");
            writer.WriteLine(" ");
            writer.WithCurlyBraces($"public static class {className}", () =>
                            {
                                foreach (var type in Types)
                                {
                                    writer.WriteLine($"// {type.ToTitleCase()} ");
                                    foreach (var (key, value) in Conversions.Where(x => x.Key != type))
                                    {
                                        writer.WriteLine($"public static {key} To{key.ToTitleCase()}(this {type} source) => Convert.{value}(source);");
                                    }

                                    writer.WriteLine("");
                                }
                            });

            return writer.GetContents();
        }

        private static Dictionary<string, string> Conversions => new()
        {
            { "int", nameof(Convert.ToInt32) },
            { "uint", nameof(Convert.ToUInt32) },
            { "short", nameof(Convert.ToInt16) },
            { "ushort", nameof(Convert.ToUInt16) },
            { "long", nameof(Convert.ToInt64) },
            { "ulong", nameof(Convert.ToUInt64) },
            { "float", nameof(Convert.ToSingle) },
            { "double", nameof(Convert.ToDouble) },
            { "decimal", nameof(Convert.ToDecimal) }
        };

        private static List<string> Types => new()
        {
            "int",
            "uint",
            "short",
            "ushort",
            "long",
            "ulong",
            "float",
            "double",
            "decimal"
        };
    }
}