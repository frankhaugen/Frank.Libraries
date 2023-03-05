using AutoFixture;
using Frank.Libraries.AutoFixture;
using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Xunit;

namespace Frank.Libraries.Tests.AutoFixture;

public class AutoFixtureTests
{
    [Fact]
    public void TestFixtureCreation()
    {
        var company = new Fixture().OmitRecursion()
                                   .Build<XmlTestModel>()
                                   .Create();
    }
}