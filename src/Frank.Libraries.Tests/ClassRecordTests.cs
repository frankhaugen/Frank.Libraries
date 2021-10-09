using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using AutoBogus;
using AutoMapper;
using FluentValidation;
using Frank.Libraries.Calculators.Types;
using Frank.Libraries.CodeGeneration.Extensions;
using Frank.Libraries.CodeGeneration.Generators;
using Frank.Libraries.CodeGeneration.Models;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Abstractions;
using Attribute = Frank.Libraries.CodeGeneration.Models.Attribute;

namespace Frank.Libraries.Tests
{
    public class ClassRecordTests
    {
        private readonly ITestOutputHelper _outputHelper;

        private List<Method> testMethods;

        public ClassRecordTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;

            testMethods = new List<Method>();
        }

        [Fact]
        public void RunTest()
        {
            var baseDirectory = new DirectoryInfo(Path.Combine("C:", "temp", "GenerationRoot"));
            var testClass = new Class("MapperProfilesTest", this.GetType().Namespace.FallbackIfNull("fff"), true);
            testClass.AddUsingNamespace(GetType());
            var typePairs = new List<(Type, Type)>() { (typeof(Currency.Currency), typeof(Vector3)), };
            var classes = new Dictionary<Class, ServiceLifetime>();

            foreach (var typePair in typePairs)
            {
                var mappingClass = GenerateMapper(typePair.Item1, "Shared", typePair.Item2);
                mappingClass.ToFile(baseDirectory);
                classes.Add(mappingClass, ServiceLifetime.Singleton);

                var validatorClass1 = GenerateValidator(typePair.Item1, "My");
                validatorClass1.ToFile(baseDirectory);
                classes.Add(validatorClass1, ServiceLifetime.Scoped);

                var validatorClass2 = GenerateValidator(typePair.Item2, "Your");
                validatorClass2.ToFile(baseDirectory);
                classes.Add(validatorClass2, ServiceLifetime.Transient);

                testClass.AddMethod(CreateMappingProfileTestMethod(mappingClass, typePair.Item1, typePair.Item2));
            }

            //testClass.ToFile(baseDirectory);
            var generator = new DependencyInjectionGenerator(classes);
            generator.ToFiles(baseDirectory);
        }

        private Class GenerateMapper(Type sourceType, string destinationPrefix, Type destinationType)
        {
            var @class = new Class($"{destinationPrefix}{sourceType.Name}Profile", $"MappingProfiles.{destinationPrefix}", extender: "Profile");
            @class.AddUsingNamespace(sourceType);
            @class.AddUsingNamespace(destinationType);
            @class.Constructor.AddCodeLine($"CreateMap<{sourceType.FullName}, {destinationType.FullName}>()", ' ', 1);
            @class.Constructor.AddCodeLines(destinationType.GetProperties().OrderBy(x => x.Name).Select(x => new CodeLine($".ForMember(x => x.{x.Name}, opt => opt.MapFrom(y => y))", 2, ' ')).ToList());
            @class.Constructor.AddCodeLine("", ';', 1);
            @class.ToFile(new DirectoryInfo(Path.Combine("C:", "temp", "CodeGeneration", "Mappers", destinationPrefix)));

            return @class;
        }

        private Class GenerateValidator(Type type, string prefix)
        {
            var @class = new Class($"{prefix}{type.Name}Validator", $"Validators.{prefix}", extender: $"{typeof(AbstractValidator<>).FullName}<{type.FullName}>");
            @class.AddUsingNamespace(type);
            @class.Constructor.AddCodeLines(type.GetProperties().OrderBy(x => x.Name).Select(x => new CodeLine($"RuleFor(x => x.{x.Name}).NotNull().NotEmpty();", 1, ' ')).ToList());
            @class.ToFile(new DirectoryInfo(Path.Combine("C:", "temp", "CodeGeneration", "Validators", prefix)));

            return @class;
        }

        private Method CreateMappingProfileTestMethod(Class mappingProfile, Type sourceType, Type destinationType)
        {
            var signature = new MethodSignature($"{mappingProfile.Name}Test");

            var output = new Method(signature);
            output.AddAttributes(new Attribute(typeof(FactAttribute)));

            output.AddCodeLines(new CodeLine("// Arrange"));
            output.AddCodeLines(new CodeLine($"var source = new {typeof(AutoFaker).FullName}<{sourceType.FullName.FallbackIfNull(sourceType.Name)}>().Configure(x => x.WithTreeDepth(2)).Generate();"));
            output.AddCodeLines(new CodeLine($"var mapper = new {typeof(AutoMapper.Mapper).FullName}(new {typeof(MapperConfiguration).FullName}(config => config.AddProfile(typeof({mappingProfile.FullName}))));"));
            output.AddCodeLines(new CodeLine("// Act"));
            output.AddCodeLines(new CodeLine($"var result = mapper.Map<{destinationType.FullName.FallbackIfNull(destinationType.Name)}>(source);"));
            output.AddCodeLines(new CodeLine("// Assert"));
            output.AddCodeLines(new CodeLine($"result.GetType().GetProperties({typeof(BindingFlags).FullName}.Public).Select(x => x.GetValue(x)).Should().NotContainNulls();"));

            return output;
        }
    }
}