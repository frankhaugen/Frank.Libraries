using Frank.Libraries.MongoDb;
using System;

namespace Frank.Libraries.Tests.TestingInfrastructure.Models
{
    public class MongoTestModel : MongoEntity
    {
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long YearlySalary { get; set; }
    }
}
