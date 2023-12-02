using Frank.Libraries.DataStorage;

namespace Frank.Libraries.Tests.Benchmark.Json;

public class JsonTestModel : IKeyed
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public long YearlySalary { get; set; }
    public Guid Id { get; set; }
}