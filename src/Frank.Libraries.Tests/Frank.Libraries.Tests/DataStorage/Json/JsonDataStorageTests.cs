using AutoBogus;
using Frank.Libraries.DataStorage.Abstractions;
using Frank.Libraries.DataStorage.Json;
using Frank.Libraries.Logging.Extensions;
using Frank.Libraries.Tests.TestingInfrastructure.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;
using ConfigurationExtensions = Frank.Libraries.Tests.TestingInfrastructure.Extensions.ConfigurationExtensions;

namespace Frank.Libraries.Tests.DataStorage.Json;

public class JsonDataStorageTests
{
    private readonly ITestOutputHelper _outputHelper;

    public JsonDataStorageTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public async Task Test1()
    {
        // Arrange
        var builder = Host.CreateApplicationBuilder();
        builder.Logging.AddTestLogger(_outputHelper);
        builder.Services.AddJsonDataStore(new ConfigurationBuilder().AddObject(new {JsonConfiguration = new JsonConfiguration()
        {
            Folder = @"C:\repos\frankhaugen\frankhaugen.github.io\LinqPadFiles\Scripts\Frank.Libraries\DataStorage"
        }}).Build(), repos => {
            repos.AddRepository<Person>();
        });

        builder.Services.AddHostedService<PersonService>();

        // Act
        var app = builder.Build();

        // Assert
        try
        {
            await app.RunAsync(new CancellationTokenSource(TimeSpan.FromSeconds(10)).Token);
        }
        catch (Exception ex)
        {
            // _outputHelper.WriteLine(builder.Services.GetDebugView());
            // _outputHelper.WriteLine(ConfigurationExtensions.GetDebugView(builder.Configuration));
            _outputHelper.WriteLine(ex.ToString());
        }
    }

    public class PersonService : BackgroundService
    {
        private readonly IRepository<Person> _repository;

        private readonly ILogger<PersonService> _logger;

        public PersonService(IRepository<Person> repository, ILogger<PersonService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("PersonService is running.");

            var peopleInitial = await _repository.GetAllAsync();

            _logger.LogInformation("Retrieved {Count} people from the repository.", peopleInitial.Count());

            var person = new AutoFaker<Person>().Configure(builder => builder.WithTreeDepth(3).WithRecursiveDepth(1)).RuleFor(x => x.Id, Guid.NewGuid).Generate();

            await _repository.AddAsync(person);

            _logger.LogInformation("Added person {Name} to the repository.", person.Name);

            var peopleUpdated = await _repository.GetAllAsync();

            _logger.LogInformation("Retrieved {Count} people from the repository.", peopleUpdated.Count());

            var personToUpdate = peopleUpdated.FirstOrDefault(p => p.Id == person.Id);
            personToUpdate.Name = "Jane Doe";
            await _repository.UpdateAsync(personToUpdate);
            _logger.LogInformation("Updated person {Name} in the repository.", personToUpdate.Name);
        }
    }


    public class Person : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public int Spouses { get; set; }

        public decimal Children { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PlaceOfBirth { get; set; }

        public byte[] Portrait { get; set; }

        public string[] Nicknames { get; set; }
    }
}