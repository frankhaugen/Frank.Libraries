using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodegenCS;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public class ConversionsGenerator
    {
        public string Generate(string namespaceName, string className, FileInfo? fileInfo = null, bool saveToFile = false)
        {
            var w = new CodegenTextWriter();

            w.WithCurlyBraces($"namespace {namespaceName}", () =>
            {
                w.WithCurlyBraces($"public static class {className}", () =>
                {
                    foreach (var type in Types)
                    {
                        w.WriteLine(w.NewLine);
                        w.WriteLine($"// {type.ToTitleCase()} ");
                        foreach (var conversion in Conversions.Where(x => x.Key != type))
                        {
                            w.WriteLine($"public static {conversion.Key} To{conversion.Key.ToTitleCase()}(this {type} source) => Convert.{conversion.Value}(source);");
                        }
                    }
                });
            });

            if (saveToFile) w.SaveToFile(fileInfo!.FullName);

            return w.GetContents();
        }

        private static Dictionary<string, string> Conversions => new()
        {
            { "int", nameof(Convert.ToInt32) },
            //types.Add("uint");
            { "short", nameof(Convert.ToInt16) },
            //types.Add("ushort");
            { "long", nameof(Convert.ToInt64) },
            //types.Add("ulong");
            { "float", nameof(Convert.ToSingle) },
            { "double", nameof(Convert.ToDouble) },
            { "decimal", nameof(Convert.ToDecimal) }
        };

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
    }
}