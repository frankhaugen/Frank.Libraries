using Frank.Libraries.Json;
using System;

namespace Frank.Libraries.Tests.TestingInfrastructure.Models
{
    public class JsonTestModel : JsonEntity
    {
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long YearlySalary { get; set; }
    }
}
