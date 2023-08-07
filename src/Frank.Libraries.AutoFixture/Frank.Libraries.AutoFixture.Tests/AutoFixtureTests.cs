using AutoFixture;

namespace Frank.Libraries.AutoFixture.Tests;

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

public class XmlTestModel
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Salary { get; set; }
    public Guid Id { get; set; }
}