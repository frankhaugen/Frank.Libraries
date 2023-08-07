using Frank.Libraries.DataStorage.Abstractions;
using Frank.Libraries.Xml;

namespace Frank.Libraries.Tests.TestingInfrastructure.Models;

public class XmlTestModel : IEntity
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Salary { get; set; }
    public Guid Id { get; set; }
}