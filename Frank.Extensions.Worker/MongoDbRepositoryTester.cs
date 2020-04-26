using Frank.Extensions.MongoDb;
using Frank.Extensions.Worker.Models;
using Microsoft.Extensions.Hosting;
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
        private readonly IMongoDbRepository<Car, MongoSettings> _mongoDbRepository;

        public MongoDbRepositoryTester(IMongoDbRepository<Car, MongoSettings> mongoDbRepository)
        {
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
                    Bought = DateTime.UtcNow
                },
                new Car()
                {
                    _Id = ObjectId.GenerateNewId(),
                    Name = "Subaru",
                    Bought = DateTime.UtcNow
                },
                new Car()
                {
                    _Id = ObjectId.GenerateNewId(),
                    Name = "Mazda",
                    Bought = DateTime.UtcNow
                },
                new Car()
                {
                    _Id = ObjectId.GenerateNewId(),
                    Name = "Nissan",
                    Bought = DateTime.UtcNow
                },
            };

            await _mongoDbRepository.InsertManyAsync(cars);

            var queryable = _mongoDbRepository.AsQueryable();

            var toyotas = queryable.Where(c => c.Name.StartsWith("toy", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine(JsonSerializer.Serialize(toyotas, new JsonSerializerOptions() { WriteIndented = true }));
        }
    }
}
