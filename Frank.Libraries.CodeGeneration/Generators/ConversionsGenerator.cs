using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using CodegenCS;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public class ConversionsGenerator
    {
        public string Generate(string namespaceName, string className, FileInfo? fileInfo = null, bool saveToFile = false)
        {
            var w = new CodegenTextWriter();

            var types = new List<string>();
            types.Add("int");
            //types.Add("uint");
            types.Add("short");
            //types.Add("ushort");
            types.Add("long");
            //types.Add("ulong");
            types.Add("float");
            types.Add("double");
            types.Add("decimal");

            var conversions = new Dictionary<string, string>();
            conversions.Add("int", nameof(Convert.ToInt32));
            //types.Add("uint");
            conversions.Add("short", nameof(Convert.ToInt16));
            //types.Add("ushort");
            conversions.Add("long", nameof(Convert.ToInt64));
            //types.Add("ulong");
            conversions.Add("float", nameof(Convert.ToSingle));
            conversions.Add("double", nameof(Convert.ToDouble));
            conversions.Add("decimal", nameof(Convert.ToDecimal));


            w.WithCurlyBraces($"namespace {namespaceName}", () =>
            {
                w.WithCurlyBraces($"public static class {className}", () =>
                {
                    foreach (var type in types)
                    //foreach (var type in types)
                    {
                        w.WriteLine(w.NewLine);
                        w.WriteLine($"// {type.ToTitleCase()} ");
                        //foreach (var @operator in operators)
                        foreach (var conversion in conversions.Where(x => x.Key != type))
                        {
                            w.WriteLine($"public static {conversion.Key} To{conversion.Key.ToTitleCase()}(this {type} source) => Convert.{conversion.Value}(source);");
                        }
                    }
                });
            });

            if(saveToFile) w.SaveToFile(fileInfo!.FullName);

            return w.GetContents();
        }
    }

    public class TestGenerator
    {
        public string Generate(string namespaceName, Type type, DirectoryInfo? directoryInfo = null, bool saveToFile = false)
        {
            var w = new CodegenTextWriter();

            w.WriteLine($"using {type.Namespace};");
            w.WriteLine($"using System.Threading.Tasks;");
            w.WriteLine($"using Xunit;");
            w.WriteLine($"using Xunit.Abstractions;");
            w.WriteLine($"using FluentAssertions;");
            w.WriteLine($"using NSubstitute;");
            w.WriteLine(w.NewLine);
            w.WithCurlyBraces($"namespace {namespaceName}", () =>
            {
                w.WithCurlyBraces($"public class {type.Name}Tests", () =>
                {
                    w.WriteLine($"private readonly ITestOutputHelper _outputHelper;");
                    w.WriteLine(w.NewLine);
                    w.WriteLine($"private readonly {type.Name} _sut{type.Name};");
                    w.WriteLine(w.NewLine);

                    w.WithCurlyBraces($"public {type.Name}Tests(ITestOutputHelper outputHelper)", () =>
                    {
                        w.WriteLine($"_outputHelper = outputHelper;");
                        w.WriteLine($"_sut{type.Name} = new {type.Name}();");
                    });

                    foreach (var method in type.GetMethods())
                    {
                        w.WriteLine(w.NewLine);
                        w.WriteLine($"[Fact]");
                        w.WithCurlyBraces($"public async Task {method.Name}Test()", () =>
                        {
                            w.WriteLine("// Arrange");
                            foreach(var param in method.GetParameters())
                            {
                                w.WriteLine($"var {param.Name?.ToLower()} = new {param.ParameterType.Name};");
                            }
                            w.WriteLine(w.NewLine);

                            w.WriteLine("// Act");
                            w.WriteLine($"var result = _sut{type.Name}.{method.Name}({string.Join(", ", method.GetParameters().Select(x => x.Name))});");
                            w.WriteLine(w.NewLine);

                            w.WriteLine("// Assert");
                            w.WriteLine($"_outputHelper.WriteLine(result);");
                            w.WriteLine($"result.Should().NotBeNull();");
                        });
                    }
                });
            });

            if(saveToFile) w.SaveToFile(Path.Combine(directoryInfo!.FullName, $"{type.Name}Tests.cs"));

            return w.GetContents();
        }
    }
}