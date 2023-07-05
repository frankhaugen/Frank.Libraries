using Frank.Libraries.DataStorage;
using Frank.Libraries.DataStorage.Abstractions;
using Frank.Libraries.Json;

namespace Frank.Libraries.Tests.TestingInfrastructure.Models;

public class JsonTestModel : IEntity
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public long YearlySalary { get; set; }
    public Guid Id { get; set; }
}