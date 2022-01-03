using System.Globalization;
using CodegenCS;
using MoreLinq.Extensions;

namespace Frank.Libraries.CodeGeneration.Generators.Enums
{
    public class CulutureGenerator : IGenerator
    {
        public string Generate(string namespaceName, string className = "Culture")
        {
            var writer = new CodegenTextWriter();
            var cultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures)
                                      .DistinctBy(x => x.TwoLetterISOLanguageName);

            writer.WriteLine("using System.ComponentModel;");
            writer.WriteLine(" // ReSharper disable InconsistentNaming");
            writer.WriteLine(" ");

            writer.WriteLine($"namespace {namespaceName};");
            writer.WriteLine(" ");
            writer.WithCurlyBraces($"public enum {className}", () =>
            {
                foreach (var culture in cultures)
                {
                    writer.WriteLine($"/// <summary> {culture.EnglishName} </summary>");
                    writer.WriteLine($"[Description(\"{culture.EnglishName}\")]");
                    writer.WriteLine($"{culture.TwoLetterISOLanguageName.ToUpperInvariant()},");
                    writer.WriteLine();
                }
            });

            return writer.GetContents();
        }
    }
}