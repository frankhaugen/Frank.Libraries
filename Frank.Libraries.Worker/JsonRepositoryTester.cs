using AutoFixture;
using Frank.Libraries.Json;
using Frank.Libraries.Worker.Models;
using Microsoft.Extensions.Hosting;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Frank.Libraries.Worker
{
    public class JsonRepositoryTester : BackgroundService
    {
        private readonly Fixture _fixture = new Fixture();
        private readonly IJsonRepository<User> _jsonRepository;

        public JsonRepositoryTester(IJsonRepository<User> jsonRepository)
        {
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