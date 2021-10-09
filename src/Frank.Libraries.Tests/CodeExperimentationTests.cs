﻿using System;
using System.Collections.Generic;
using System.Globalization;
using AutoBogus;
using Frank.Libraries.CodeGeneration.Generators;
using Frank.Libraries.IRC.Properties;
using Frank.Libraries.Json;
using Frank.Libraries.ML.LanguageDetection;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class CodeExperimentationTests
    {
        private readonly string _csv = "Name;age;DOB\nBob;28;2000-01-01\nRoss;77;2000-01-01\nDave;11;2000-01-01\ncarl;10;2000-01-01";

        private readonly ITestOutputHelper _outputHelper;

        public CodeExperimentationTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void GetCultures()
        {
            _outputHelper.WriteLine(CultureEnumGenerator.Generate());
        }

        [Fact]
        public void GetResources()
        {
            var myResourceSet = Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            _outputHelper.WriteLine(myResourceSet.ToJson());

            //File.WriteAllText(, myResourceSet.ToJson());
        }

        [Fact]
        public void TestIdentify()
        {
            var decimalValue = "10,10";
            var decimalResult = Identify(decimalValue);
            // decimalResult.Should<TypeCode>().Be<TypeCode>()  .Should()..Should().BeOfType<TypeCode>();

            _outputHelper.WriteLine(AppDomain.CurrentDomain.FriendlyName);
        }

        private TypeCode Identify(string value)
        {
            if (decimal.TryParse(value, out _))
            {
                return TypeCode.Decimal;
            }

            throw new ArgumentException(_csv);
        }

        [Fact]
        public void TestLanguageObject()
        {
            var languages = new AutoFaker<LanguageModel>().Generate(4);

            var json = languages.ToJson(true);

            var result = json.FromJson<List<LanguageModel>>();

            _outputHelper.WriteLine(result.ToJson());
        }
    }
}