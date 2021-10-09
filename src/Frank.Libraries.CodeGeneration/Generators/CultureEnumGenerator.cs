using System.Globalization;
using CodegenCS;
using Frank.Libraries.CodeGeneration.Extensions;
using MoreLinq.Extensions;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public static class CultureEnumGenerator
    {
        public static string Generate(string namespaceName = "System.Localization")
        {
            var writer = new CodegenTextWriter();
            var cultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures).DistinctBy(x => x.TwoLetterISOLanguageName);

            writer.WithCurlyBraces($"namespace {namespaceName.ToNameCase()}", () =>
            {
                writer.WithCurlyBraces($"public enum Culture", () =>
                {
                    foreach (var culture in cultures)
                    {
                        writer.WriteLine($"/// <summary>");
                        writer.WriteLine($"/// {culture.EnglishName}");
                        writer.WriteLine($"/// </summary>");
                        writer.WriteLine($"[Description(\"{culture.EnglishName}\")]");
                        writer.WriteLine($"{culture.TwoLetterISOLanguageName.ToUpperInvariant()},");
                        writer.WriteLine();
                    }
                });
            });

            return writer.GetContents();
        }
    }
}