using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodegenCS;
using Frank.Libraries.CodeGeneration.Extensions;
using MoreLinq.Extensions;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public class TestGenerator : IGenerator
    {
        public string Generate(string namespaceName, string className) => Generate(namespaceName, GetType().Assembly.GetTypes().First(x => x.Name == className && x.Namespace == namespaceName));

        public string Generate(string namespaceName, Type type, List<string>? ignoreMethods = null)
        {
            var writer = new CodegenTextWriter();
            var constructors = type.GetConstructors();
            var constructorParameters = new List<ParameterInfo>();
            var isNotStatic = !type.IsAbstract && !type.IsSealed;

            var types = new List<Type>();
            var namespaces = new List<string>()
            {
                type.Namespace,
                "System",
                "System.Threading.Tasks",
                "Xunit",
                "Xunit.Abstractions",
                "FluentAssertions",
                "NSubstitute",
                "Frank.Libraries.Extensions"
            };

            var returnTypes = type.GetMethods().Select(x => x.ReturnType);
            var parameterTypes = type.GetMethods().SelectMany(x => x.GetParameters()).Select(x => x.ParameterType);
            types.AddRange(returnTypes);
            types.AddRange(parameterTypes);

            if (constructors.Any())
            {
                constructors.First().GetParameters().DoForEach(x => constructorParameters.Add(x));
            }

            constructorParameters.DoForEach(x => namespaces.AddUnique(x.GetType().Namespace));
            Enumerable.DistinctBy(types, x => x.Name).DoForEach(x => namespaces.AddUnique(x.Namespace));

            namespaces.Where(x => !string.IsNullOrWhiteSpace(x)).OrderBy(x => x).ForEach(x => writer.WriteLine($"using {x};"));

            writer.Write(writer.NewLine);
            writer.WriteLine($"namespace {namespaceName};");
            writer.WriteLine(" ");
            writer.WithCurlyBraces($"public class {type.Name}Tests", () =>
                            {
                                var constructorParametersDictionary = constructorParameters.ToDictionary(x => $"_{x.ParameterType.Name.ToCamelcase()}", x => $"private readonly {x.ParameterType.Name} _{(x.ParameterType.IsInterface ? x.ParameterType.Name.Remove(0, 1).ToCamelcase() : x.ParameterType.Name.ToCamelcase())} = Substitute.For<{x.ParameterType.Name}>();");
                                constructorParametersDictionary.DoForEach(x => writer.WriteLine(x.Value));

                                writer.WriteLine($"private readonly ITestOutputHelper _outputHelper;");
                                writer.Write(writer.NewLine);

                                writer.WithCurlyBraces($"public {type.Name}Tests(ITestOutputHelper outputHelper)", () =>
                                {
                                    writer.WriteLine($"_outputHelper = outputHelper;");

                                    if (isNotStatic)
                                    {
                                        if (constructorParametersDictionary.Any())
                                        {
                                            writer.WriteLine($"_sut{type.Name} = new {type.Name}({string.Join(", ", constructorParametersDictionary.Keys)});");
                                        }
                                        else
                                        {
                                            writer.WriteLine($"_sut{type.Name} = new {type.Name}();");
                                        }

                                    }
                                });
                                writer.Write(writer.NewLine);

                                if (isNotStatic)
                                {
                                    writer.WriteLine($"private readonly {type.Name} _sut{type.Name};");
                                    writer.Write(writer.NewLine);

                                    var methodLookup = type.GetMethods().ToLookup(x => x.Name, info => info);

                                    foreach (var methodGrouping in methodLookup)
                                    {
                                        if (ignoreMethods != null && ignoreMethods.Any(x => x == methodGrouping.Key)) continue;

                                        if (methodGrouping.Count() == 1)
                                        {
                                            if (methodGrouping.First().IsPrivate) continue;
                                            SetupInstanceMethodTest(writer, type, methodGrouping.First());
                                        }
                                        else
                                        {
                                            var i = 0;
                                            foreach (var methodInfo in methodGrouping)
                                            {
                                                i++;
                                                if (methodInfo.IsPrivate) continue;
                                                SetupInstanceMethodTest(writer, type, methodInfo, i.ToString());
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    var methodLookup = type.GetMethods().ToLookup(x => x.Name, info => info);

                                    foreach (var methodGrouping in methodLookup)
                                    {
                                        if (ignoreMethods != null && ignoreMethods.Any(x => x == methodGrouping.Key)) continue;

                                        if (methodGrouping.Count() == 1)
                                        {
                                            if (methodGrouping.First().IsPrivate) continue;
                                            if (methodGrouping.First().IsDefined(typeof(ExtensionAttribute))) SetupExtensionMethodTest(writer, methodGrouping.First());
                                        }
                                        else
                                        {
                                            var i = 0;
                                            foreach (var methodInfo in methodGrouping)
                                            {
                                                i++;
                                                if (methodInfo.IsPrivate) continue;
                                                if (methodInfo.IsDefined(typeof(ExtensionAttribute))) SetupExtensionMethodTest(writer, methodInfo, i.ToString());
                                            }
                                        }
                                    }
                                    //foreach (var method in type.GetMethods())
                                    //{
                                    //    if (method.IsPrivate) continue;
                                    //    if (method.IsDefined(typeof(ExtensionAttribute))) SetupExtensionMethodTest(writer, method);
                                    //    //SetupInstanceMethodTest(writer, type, method);
                                    //}
                                }

                            });

            return writer.GetContents();
        }

        private void SetupExtensionMethodTest(CodegenTextWriter writer, MethodInfo method, string suffix = "")
        {
            writer.Write(writer.NewLine);
            writer.WriteLine($"[Fact]");
            writer.WithCurlyBraces($"public async Task {method.Name}Test{suffix}()", () =>
            {
                writer.WriteLine("// Arrange");
                var methodParameters = method.GetParameters().ToList();
                var thisParameter = methodParameters.First();
                methodParameters.RemoveAt(0);

                foreach (var param in methodParameters)
                {
                    writer.WriteLine($"var {param.Name?.ToCamelcase()} = default({param.ParameterType.Name});");
                }

                writer.WriteLine($"var {thisParameter.Name.ToCamelcase()} = default({thisParameter.ParameterType.Name});");
                writer.Write(writer.NewLine);

                writer.WriteLine("// Act");

                var awaitPrefix = "";
                if (method.IsAsync()) awaitPrefix = "await ";

                writer.WriteLine($"var result = {awaitPrefix}{thisParameter.Name.ToCamelcase()}.{method.Name}({string.Join(", ", methodParameters.Where(x => !x.HasDefaultValue).Select(x => x.Name))});");
                writer.Write(writer.NewLine);

                writer.WriteLine("// Assert");
                writer.WriteLine($"_outputHelper.WriteLine(result);");
                writer.WriteLine($"result.ToString().Should().NotBeNullOrEmpty();");
            });
        }

        private void SetupInstanceMethodTest(CodegenTextWriter writer, Type type, MethodInfo method, string suffix = "")
        {
            writer.Write(writer.NewLine);
            writer.WriteLine($"[Fact]");
            writer.WithCurlyBraces($"public async Task {method.Name}Test{suffix}()", () =>
            {
                writer.WriteLine("// Arrange");
                foreach (var param in method.GetParameters())
                {
                    writer.WriteLine($"var {param.Name} = default({param.ParameterType.Name});");
                }
                writer.Write(writer.NewLine);

                writer.WriteLine("// Act");

                var awaitPrefix = "";
                if (method.IsAsync()) awaitPrefix = "await ";

                writer.WriteLine($"var result = {awaitPrefix}_sut{type.Name}.{method.Name}({string.Join(", ", method.GetParameters().Where(x => !x.HasDefaultValue).Select(x => x.Name))});");
                writer.Write(writer.NewLine);

                writer.WriteLine("// Assert");
                writer.WriteLine($"_outputHelper.WriteLine(result);");
                writer.WriteLine($"result.ToString().Should().NotBeNullOrEmpty();");
            });
        }
    }
}