using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodegenCS;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public class TestGenerator : IGenerator
    {
        public string Generate(string namespaceName, string className) => Generate(namespaceName, GetType().Assembly.GetTypes().First(x => x.Name == className && x.Namespace == namespaceName));

        public string Generate(string namespaceName, Type type)
        {
            var writer = new CodegenTextWriter();
            var constructors = type.GetConstructors();
            var constructorParameters = new List<ParameterInfo>();

            if (constructors.Any())
            {
                constructors.First().GetParameters().DoForEach(x => constructorParameters.Add(x));
            }

            writer.WriteLine($"using {type.Namespace};");
            writer.WriteLine($"using System.Threading.Tasks;");
            writer.WriteLine($"using Xunit;");
            writer.WriteLine($"using Xunit.Abstractions;");
            writer.WriteLine($"using FluentAssertions;");
            writer.WriteLine($"using NSubstitute;");
            writer.WriteLine($"using Frank.Libraries.Extensions;");

            constructorParameters.DoForEach(x => writer.WriteLine($"using {x.GetType().Namespace};"));

            writer.Write(writer.NewLine);
            writer.WriteLine($"namespace {namespaceName};");
            writer.WriteLine(" ");
            writer.WithCurlyBraces($"public class {type.Name}Tests", () =>
                            {
                                constructorParameters.DoForEach(x => writer.WriteLine($"private readonly {x.GetType().Name} _{x.GetType().Name.ToCamelcase()} = Substitue.For<{x.GetType().Name}>;"));

                                writer.WriteLine($"private readonly ITestOutputHelper _outputHelper;");
                                writer.Write(writer.NewLine);
                                if (!type.IsAbstract && !type.IsSealed)
                                {
                                    writer.WriteLine($"private readonly {type.Name} _sut{type.Name};");
                                }
                                writer.Write(writer.NewLine);

                                writer.WithCurlyBraces($"public {type.Name}Tests(ITestOutputHelper outputHelper)", () =>
                                {
                                    writer.WriteLine($"_outputHelper = outputHelper;");

                                    if (!type.IsAbstract && !type.IsSealed)
                                    {
                                        writer.WriteLine($"_sut{type.Name} = new {type.Name}();");
                                    }
                                });

                                foreach (var method in type.GetMethods())
                                {
                                    if (method.IsPrivate)
                                    {
                                        continue;
                                    }
                                    if (method.IsDefined(typeof(ExtensionAttribute)))
                                    {
                                        SetupExtensionMethodTest(writer, method);
                                    }
                                    else
                                    {
                                        SetupInstanceMethodTest(writer, type, method);
                                    }
                                }
                            });

            return writer.GetContents();
        }

        private void SetupExtensionMethodTest(CodegenTextWriter w, MethodInfo method)
        {
            w.Write(w.NewLine);
            w.WriteLine($"[Fact]");
            w.WithCurlyBraces($"public async Task {method.Name}Test()", () =>
            {
                w.WriteLine("// Arrange");
                var methodParameters = method.GetParameters().ToList();
                var thisParameter = methodParameters.First();
                methodParameters.RemoveAt(0);

                foreach (var param in methodParameters)
                {
                    w.WriteLine($"var {param.Name?.ToCamelcase()} = new {param.ParameterType.Name}();");
                }
                w.Write(w.NewLine);

                w.WriteLine("// Act");
                w.WriteLine($"var result = {thisParameter.Name.ToCamelcase()}.{method.Name}({string.Join(", ", methodParameters.Select(x => x.Name))});");
                w.Write(w.NewLine);

                w.WriteLine("// Assert");
                w.WriteLine($"_outputHelper.WriteLine(result);");
                w.WriteLine($"result.Should().NotBeNull();");
            });
        }

        private void SetupInstanceMethodTest(CodegenTextWriter w, Type type, MethodInfo method)
        {
            w.Write(w.NewLine);
            w.WriteLine($"[Fact]");
            w.WithCurlyBraces($"public async Task {method.Name}Test()", () =>
            {
                w.WriteLine("// Arrange");
                foreach (var param in method.GetParameters())
                {
                    w.WriteLine($"var {param.Name?.ToLower()} = new {param.ParameterType.Name}();");
                }
                w.Write(w.NewLine);

                w.WriteLine("// Act");
                w.WriteLine($"var result = _sut{type.Name}.{method.Name}({string.Join(", ", method.GetParameters().Select(x => x.Name))});");
                w.Write(w.NewLine);

                w.WriteLine("// Assert");
                w.WriteLine($"_outputHelper.WriteLine(result);");
                w.WriteLine($"result.Should().NotBeNull();");
            });
        }
    }
}