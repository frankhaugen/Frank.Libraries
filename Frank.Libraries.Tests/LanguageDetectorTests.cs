using FluentAssertions;
using Frank.Libraries.AI.LanguageDetection;
using Frank.Libraries.Enums.Countries;
using Frank.Libraries.Enums.Extensions;
using Xunit;

namespace Frank.Libraries.Tests
{
    public class LanguageDetectorTests
    {
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

        [Fact]
        public void Detect_TextIsNorwegian_ReturnsNorwegian()
        {
            var text = "Mitt navn er Frank";

            var detector = new LanguageDetectionService(new LanguageDetectionOptions());

            var result = detector.Detect(text);

            result.Should().NotBeNull();
            result?.LanguageCode.Should().Be(LanguageCode.NOR);
        }

        [Fact]
        public void Detect_TextIsChinese_ReturnsChinese()
        {
            var text = "汉堡包/漢堡包, 汉堡/漢堡";

            var detector = new LanguageDetectionService(new LanguageDetectionOptions());

            var result = detector.Detect(text);

            result.Should().NotBeNull();
            result?.LanguageCode.Should().Be(LanguageCode.CHI);
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

            result.LanguageCode.Should().NotBe(LanguageCode.INA);
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
