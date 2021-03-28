using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Frank.Libraries.Calculators.Types;
using Frank.Libraries.CodeGeneration.Extensions;
using Frank.Libraries.CodeGeneration.Models;
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
            var testClass = new Class("MapperProfilesTest", this.GetType().Namespace.FallbackIfNull("fff"));
            var typePairs = new List<(Type, Type)>() { (typeof(Currency.Currency), typeof(Vector3)), };

            foreach (var typePair in typePairs)
            {
                var mappingClass = GenerateMapper(typePair.Item1, "AI", typePair.Item2);
                mappingClass.ToFile(baseDirectory);
                var validatorClass1 = GenerateValidator(typePair.Item1, "CurrencyEngine");
                validatorClass1.ToFile(baseDirectory);
                var validatorClass2 = GenerateValidator(typePair.Item2, "Calculator");
                validatorClass2.ToFile(baseDirectory);
                testClass.AddMethod(CreateMappingProfileTestMethod(mappingClass, typePair.Item1, typePair.Item2));
            }

            testClass.ToFile(baseDirectory);
        }

        private Class GenerateMapper(Type sourceType, string destinationPrefix, Type destinationType)
        {
            var @class = new Class($"{destinationPrefix}{sourceType.Name}Profile", $"MappingProfiles.{destinationPrefix}", "Profile");
            @class.Constructor.AddCodeLine($"CreateMap<{sourceType.FullName}, {destinationType.FullName}>()", ' ', 1);
            @class.Constructor.AddCodeLines(destinationType.GetProperties().OrderBy(x => x.Name).Select(x => new CodeLine($".ForMember(x => x.{x.Name}, opt => opt.MapFrom(y => y))", 2, ' ')).ToList());
            @class.Constructor.AddCodeLine("", ';', 1);
            @class.ToFile(new DirectoryInfo(Path.Combine("C:", "temp", "CodeGeneration", "Mappers", destinationPrefix)));

            return @class;
        }

        private Class GenerateValidator(Type type, string prefix)
        {
            var @class = new Class($"{prefix}{type.Name}Validator", $"Validators.{prefix}", $"AbstractValidator<{type.FullName}>");
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
            output.AddCodeLines(new CodeLine($"var source = new AutoFaker<{sourceType.FullName.FallbackIfNull(sourceType.Name)}>().Configure(x => x.WithTreeDepth(2)).Generate();"));
            output.AddCodeLines(new CodeLine($"var mapper = new Mapper(new MapperConfiguration(config => config.AddProfile(typeof({mappingProfile.Name}))));"));
            output.AddCodeLines(new CodeLine("// Act"));
            output.AddCodeLines(new CodeLine($"var result = mapper.Map<{destinationType.FullName.FallbackIfNull(destinationType.Name)}>(source);"));
            output.AddCodeLines(new CodeLine("// Assert"));
            output.AddCodeLines(new CodeLine($"result.GetType().GetProperties(BindingFlags.Public).Select(x => x.GetValue(x)).Should().NotContainNulls();"));

            return output;
        }
    }
}