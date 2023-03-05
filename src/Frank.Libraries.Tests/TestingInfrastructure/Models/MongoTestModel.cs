using System;
using Frank.Libraries.MongoDb;
using MongoDB.Bson;

namespace Frank.Libraries.Tests.TestingInfrastructure.Models;

public class MongoTestModel : IMongoEntity
{
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public long YearlySalary { get; set; }
    public ObjectId Id { get; set; }
}