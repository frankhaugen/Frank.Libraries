using FluentAssertions;
using Frank.Libraries.AI.LanguageDetection;
using Frank.Libraries.Enums.Countries;
using Frank.Libraries.Enums.Extensions;
using Frank.Libraries.Json;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests.LanguageDetection
{
    public class LanguageDetectorTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public LanguageDetectorTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Detect_TextIsEnglish_ReturnsEnglish()
        {
            var text = "My name is Frank, and I am a Norwegian";

            var detector = new LanguageDetectionService(new LanguageDetectionOptions());
            var result = detector.Detect(text);

            result.Should().NotBeNull();
            result?.LanguageCode.Should().Be(LanguageCode.ENG);
            result?.Name.Should().Be(LanguageCode.ENG.GetName());
        }

        [Theory]
        [InlineData("My name is Frank, and I am a Norwegian", LanguageCode.ENG)]
        [InlineData("Mitt navn er Frank", LanguageCode.NOR)]
        [InlineData("好的", LanguageCode.CHI)]
        [InlineData("Пожалуйста ", LanguageCode.RUS)]
        [InlineData("Wo ist es? ", LanguageCode.GER)]
        public void Detect(string text, LanguageCode expected)
        {
            var detector = new LanguageDetectionService(new LanguageDetectionOptions());
            var result = detector.Detect(text);

            result.Should().NotBeNull();
            result?.LanguageCode.Should().Be(expected);
            result?.Name.Should().Be(expected.GetName());
        }

        [Fact]
        public void DetectAll()
        {
            var text = "rgeg hnøae uhbø eo ubh æeot i8h 308 y63åt80uh";

            var detector = new LanguageDetectionService(new LanguageDetectionOptions());
            var result = detector.DetectAll(text);

            _outputHelper.WriteLine(result.ToJson());
        }

        [Fact]
        public void Detect_TextIsEmptyString_ReturnsNull()
        {
            var text = "";

            var detector = new LanguageDetectionService(new LanguageDetectionOptions());

            var result = detector.Detect(text);

            result.Should().BeNull();
        }

        [Fact]
        public void Is_TextIsNorwegian_ReturnsTrue()
        {
            var text = "Mitt navn er Frank";

            var detector = new LanguageDetectionService(new LanguageDetectionOptions());

            var result = detector.Is(LanguageCode.NOR, text);

            result.Should().NotBeNull();
            result?.Should().BeTrue();
        }

        [Fact]
        public void Is_TextIsInterlinguaThatDoesNotExist_ReturnsNull()
        {
            var text = "Patre nostre, qui es in le celos, que tu nomine sia sanctificate; que tu regno veni; que tu voluntate sia facite como in le celo, etiam super le terra.";

            var detector = new LanguageDetectionService(new LanguageDetectionOptions());

            var result = detector.Is(LanguageCode.INA, text);

            result.Should().BeNull();
        }

        [Fact]
        public void Detect_TextIsInterlinguaThatDoesNotExist_DoesNotReturnInterlingua()
        {
            var text = "Patre nostre, qui es in le celos, que tu nomine sia sanctificate; que tu regno veni; que tu voluntate sia facite como in le celo, etiam super le terra." +
                "Da nos hodie nostre pan quotidian, e pardona a nos nostre debitas como etiam nos los pardona a nostre debitores. E non induce nos in tentation, sed libera nos del mal. Amen.";

            var detector = new LanguageDetectionService(new LanguageDetectionOptions());

            var result = detector.Detect(text);

            result!.LanguageCode.Should().NotBe(LanguageCode.INA);
        }

        [Fact]
        public void Detect_TextIsKlingonThatDoesNotExist_ReturnsNull()
        {
            var text = "HeghluʼmeH QaQ jajvam. bortaS bIr jabluʼDIʼ reH QaQquʼ nayʼ. bIlughbeʼ. Dochvetlh vISoplaHbeʼ. jIyajbeʼ.";

            var detector = new LanguageDetectionService(new LanguageDetectionOptions());

            var result = detector.Detect(text);

            result.Should().BeNull();
        }
    }
}
