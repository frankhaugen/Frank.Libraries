using System.Collections.Generic;
using CodegenCS;
using Frank.Libraries.CodeGeneration.Extensions;
using Frank.Libraries.CodeGeneration.Models;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public class ConstantsGenerator : IGenerator
    {
        private readonly List<Resource> _resources;

        public ConstantsGenerator(List<Resource> resources) => _resources = resources;
        public ConstantsGenerator() => _resources = new List<Resource>();

        public string Generate(string namespaceName, string className)
        {
            var writer = new CodegenTextWriter();

            writer.WriteLine($"namespace {namespaceName};");
            writer.WriteLine(" ");
            writer.WithCurlyBraces($"public static class {className.ToNameCase()}", () =>
            {
                foreach (var resource in _resources)
                {
                    writer.WriteLine($"public const string {resource.Key.ToNameCase()} = \"{resource.Value}\";");
                }
            });

            return writer.GetContents();
        }
    }
}