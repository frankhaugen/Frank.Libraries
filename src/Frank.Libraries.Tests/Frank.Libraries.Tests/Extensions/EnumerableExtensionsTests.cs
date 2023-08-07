using System.Security.Cryptography;
using AutoBogus;
using FluentAssertions;
using Frank.Libraries.Extensions;
using Frank.Libraries.Tests.TestingInfrastructure.Models;

namespace Frank.Libraries.Tests.Extensions;

public class EnumerableExtensionsTests
{
    public EnumerableExtensionsTests() => CreateTestModel();

    [Fact]
    public void Batch_ReturnsCorrectCount()
    {
        // Arrange
        var items = CreateTestModels(100);
        var maxItems = 10;

        // Act
        var result = items.Batch(maxItems);

        // Assert
        result.Should()
              .HaveCount(10);
    }

    [Fact]
    public void Random_ReturnsRandomItem()
    {
        // Arrange
        var items = CreateTestModels();

        // Act
        var result = items.Random();

        // Assert
        items.Should()
             .Contain(result);
    }

    [Fact]
    public void LeftJoin()
    {
        // Arrange
        var persons = new AutoFaker<Person>().Generate(5);
        var users = new AutoFaker<User>().Generate(5);
        persons.Add(new Person { Email = "frank.haugen@gmail.com", Id = RandomNumberGenerator.GetInt32(0, 1024), Name = "Frank R. H." });
        users.Add(new User { Email = "frank.haugen@gmail.com", Id = Guid.NewGuid(), FirstName = "Frank", LastName = "R. H." });

        // Act
        var result = persons.LeftJoin<Person, User, string, UserPerson>(users, person => person.Email, user => user.Email, (person, user) => new UserPerson { Email = person.Email, FullName = $"{user.LastName}, {user.FirstName}", PersonId = person.Id, UserId = user.Id, Id = RandomNumberGenerator.GetInt32(0, 512) });

        // Assert
    }

    private TestDocument CreateTestModel() => new AutoFaker<TestDocument>().Generate();

    private List<TestDocument> CreateTestModels(int count = 10) => new AutoFaker<TestDocument>().Generate(count);

    private class UserPerson
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }

    private class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    private class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}