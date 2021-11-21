using System;
using System.IO;
using System.Linq;
using CodegenCS;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public class TestGenerator
    {
        public string Generate(string namespaceName, Type type, DirectoryInfo? directoryInfo = null)
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
                            foreach (var param in method.GetParameters())
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

            return w.GetContents();
        }
    }
}