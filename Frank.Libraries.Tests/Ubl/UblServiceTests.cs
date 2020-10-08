using System.IO;
using FluentAssertions;
using Frank.Libraries.Ubl;
using Xunit;

namespace Frank.Libraries.Tests.Ubl
{
    public class UblServiceTests
    {
        [Theory]
        [InlineData("Invoice1.xml")]
        public void DeserializeToInvoiceType_StateUnderTest_ExpectedBehavior(string filename)
        {
            // Arrange
            var service = new UblService();

            var pathToFile = Path.Combine(Directory.GetCurrentDirectory(), "TestingInfrastructure", "Files", "Xml", filename);
            File.Exists(pathToFile).Should().BeTrue();
            var xml = File.ReadAllText(pathToFile);

            // Act
            var result = service.DeserializeToInvoiceType(xml);

            // Assert
            result.Should().NotBeNull();
        }

        [Fact]
        public void Serialize()
        {
            //var invoice = new AutoFaker<InvoiceType>().Generate();

        }
    }
}
