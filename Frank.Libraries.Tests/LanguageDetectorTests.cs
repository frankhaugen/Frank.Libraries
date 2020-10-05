using System.Linq;
using FluentAssertions;
using Frank.Libraries.AI.LanguageDetection;
using Xunit;

namespace Frank.Libraries.Tests
{
    public class LanguageDetectorTests
    {
        [Fact]
        public void Latvian()
        {
            string[] texts = new[] {
                "čau, man iet labi, un kā iet tev?",
                "Ukrainas prezidenta pienākumu izpildītājs Oleksandrs Turčinovs trešdienas vakarā devis Krimas separātistu "
            };

            Test("lv", texts, new[] { new[] { "en", "fr", }, new[] { "lt", "pt" } });
        }

        [Fact]
        public void French()
        {
            string[] texts = new[] {
                "Le français est une langue indo-européenne de la famille des langues romanes. Le français s'est formé en France",
                "La langue française commence à prendre de l'importance en 1250, lorsque Saint Louis commande une traduction de la Bible en français.",
                "Nous voulons donc que dorénavant tous arrêts, et ensemble toutes autres procédures, soit de nos cours souveraines ou autres subalternes et inférieures, soit des registres, enquêtes,",
                "il neige et le soleil brille et nous regardons la radio et la télé. le cinéma est très français"
            };

            Test("fr", texts, new[] { new[] { "en", "it", "es", "pt" } });
        }

        [Fact]
        public void Issue_1()
        {
            string[] texts = new[] { "Výsledky kvalifikace slopestylu na ZOH v Soči" };

            Test("cs", texts);
            Test("cs", texts, new[] { new[] { "cs", "sk" } });
            Test("cs", texts, new[] { new[] { "en", "cs", "sk", "lv" } });
        }

        [Fact]
        public void Issue_2()
        {
            string text = "Výsledky kola švýcarské hokejové ligy";

            LanguageDetector detector = new LanguageDetector();
            detector.RandomSeed = 1;
            detector.AddAllLanguages();

            Assert.Equal("sk", detector.Detect(text));
            detector.DetectAll(text).Should().HaveCount(1);

            detector = new LanguageDetector();
            detector.RandomSeed = 1;
            detector.ConvergenceThreshold = 0.9;
            detector.MaxIterations = 50;
            detector.AddAllLanguages();

            Assert.Equal("sk", detector.Detect(text));
            Assert.Equal(2, detector.DetectAll(text).Count());
        }

        private void Test(string lang, string[] texts, string[][] pairs = null!)
        {
            LanguageDetector detector = new LanguageDetector { RandomSeed = 1 };
            detector.AddAllLanguages();

            foreach (var text in texts) Assert.Equal(lang, detector.Detect(text));

            foreach (var pair in pairs)
            {
                detector = new LanguageDetector();
                detector.RandomSeed = 1;
                detector.AddLanguages(pair);
                detector.AddLanguages(lang);

                foreach (var text in texts)
                    Assert.Equal(lang, detector.Detect(text));
            }
        }
    }
}
