using AutoFixture;
using Frank.Extensions.Json;
using Frank.Extensions.Worker.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Frank.Extensions.Worker
{
    public class JsonRepositoryTester : BackgroundService
    {
        private readonly Fixture _fixture = new Fixture();
        private readonly ILogger<JsonRepositoryTester> _logger;
        private readonly IJsonRepository<User, JsonSettings> _jsonRepository;

        public JsonRepositoryTester(ILogger<JsonRepositoryTester> logger, IJsonRepository<User, JsonSettings> jsonRepository)
        {
            _logger = logger;
            _jsonRepository = jsonRepository;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var users = _fixture.CreateMany<User>();

            await _jsonRepository.AddAsync(users);

            await _jsonRepository.SaveChangesAsync();

            var result = await _jsonRepository.GetAsync();

            Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions() { WriteIndented = true }));

        }
    }
}
