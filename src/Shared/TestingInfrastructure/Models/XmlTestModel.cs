using Frank.Libraries.DataStorage;

namespace TestingInfrastructure.Models;

public class XmlTestModel : IKeyed
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Salary { get; set; }
    public Guid Id { get; set; }
}