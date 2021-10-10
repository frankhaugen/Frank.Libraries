﻿using System;
using System.Collections.Generic;
using System.Linq;
using CodegenCS;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Generators.FuentCalculation
{
    public static class FluentCalculatorPrimitivesConversionsGenerator
    {
        public static string Generate(string namespaceName = "Frank.Libraries.Calculators.FluentCalculation", string className = "FluentCalculatorPrimitivesConversions")
        {
            var writer = new CodegenTextWriter();
            writer.WriteLine($"using System;");
            writer.WriteLine($" ");
            writer.WithCurlyBraces($"namespace {namespaceName}", () =>
            {
                writer.WithCurlyBraces($"public static class {className}", () =>
                {
                    foreach (var type in Types)
                    {
                        writer.WriteLine($"// {type.ToTitleCase()} ");
                        foreach (var conversion in Conversions.Where(x => x.Key != type))
                        {
                            writer.WriteLine($"public static {conversion.Key} To{conversion.Key.ToTitleCase()}(this {type} source) => Convert.{conversion.Value}(source);");
                        }
                        writer.WriteLine("");
                    }
                });
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