using AutoFixture;
using Frank.Extensions.MongoDb;
using Frank.Extensions.Worker.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Frank.Extensions.Worker
{
    public class MongoDbRepositoryTester : BackgroundService
    {
        private readonly Fixture _fixture = new Fixture();
        private readonly ILogger<MongoDbRepositoryTester> _logger;
        private readonly IMongoDbRepository<Car, MongoSettings> _mongoDbRepository;

        public MongoDbRepositoryTester(ILogger<MongoDbRepositoryTester> logger, IMongoDbRepository<Car, MongoSettings> mongoDbRepository)
        {
            _logger = logger;
            _mongoDbRepository = mongoDbRepository;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var cars = new List<Car>()
            {
                new Car()
                {
                    _Id = ObjectId.GenerateNewId(),
                    Name = "Toyota",
                    Bought = new BsonDateTime(DateTime.UtcNow)
                },
                new Car()
                {
                    _Id = ObjectId.GenerateNewId(),
                    Name = "Subaru",
                    Bought = new BsonDateTime(DateTime.UtcNow)
                },
                new Car()
                {
                    _Id = ObjectId.GenerateNewId(),
                    Name = "Mazda",
                    Bought = new BsonDateTime(DateTime.UtcNow)
                },
                new Car()
                {
                    _Id = ObjectId.GenerateNewId(),
                    Name = "Nissan",
                    Bought = new BsonDateTime(DateTime.UtcNow)
                },
            };

            await _mongoDbRepository.InsertManyAsync(cars);

            var result = _mongoDbRepository.AsQueryable().ToList();

            Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions() { WriteIndented = true }));
        }
    }
}
