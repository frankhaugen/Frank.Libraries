using System.Collections.Generic;
using System.IO;
using CodegenCS;
using Frank.Libraries.CodeGeneration.Extensions;
using Frank.Libraries.CodeGeneration.Models;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public class ConstantsGenerator
    {
        public string Generate(string namespaceName, string className, List<Resource> resources, DirectoryInfo? directoryInfo = null, bool saveToFile = false)
        {
            var w = new CodegenTextWriter();

            w.WithCurlyBraces($"namespace {namespaceName.ToNameCase()}", () =>
            {
                w.WithCurlyBraces($"public static class {className.ToNameCase()}", () =>
                {
                    foreach (var resource in resources)
                    {
                        w.WriteLine($"public const string {resource.Key.ToNameCase()} = \"{resource.Value}\";");
                    }
                });
            });

            if (saveToFile) w.SaveToFile(new FileInfo(Path.Combine(directoryInfo!.FullName, $"{className.ToNameCase()}.cs")).FullName);

            return w.GetContents();
        }
    }
}