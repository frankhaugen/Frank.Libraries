using Frank.Libraries.MongoDb;
using MongoDB.Bson;
using System;

namespace Frank.Libraries.Tests.TestingInfrastructure.Models
{
    public class MongoTestModel : IMongoEntity
    {
        public ObjectId Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long YearlySalary { get; set; }
    }
}
