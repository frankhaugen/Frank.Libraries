using Frank.Libraries.DataStorage;

namespace TestingInfrastructure.Models;

public class JsonTestModel : IKeyed
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public long YearlySalary { get; set; }
    public Guid Id { get; set; }
}