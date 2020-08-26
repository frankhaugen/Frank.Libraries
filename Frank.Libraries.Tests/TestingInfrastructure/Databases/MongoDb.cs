using Frank.Libraries.Tests.TestingInfrastructure.Models;
using Mongo2Go;
using MongoDB.Driver;

namespace Frank.Libraries.Tests.TestingInfrastructure.Databases
{
    public class MongoDb
    {
        internal static MongoDbRunner _runner;
        internal static IMongoCollection<TestDocument> _collection;

        internal static void CreateConnection()
        {
            _runner = MongoDbRunner.Start();

            MongoClient client = new MongoClient(_runner.ConnectionString);
            var database = client.GetDatabase("IntegrationTest");
            _collection = database.GetCollection<TestDocument>("TestCollection");
        }
    }
}
