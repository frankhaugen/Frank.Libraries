using FluentAssertions;
using Xunit;

namespace Frank.Libraries.Tests
{
    public class MapperTests
    {
        [Fact]
        public void Map_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mapper = new Mapper.Mapper();
            var source = new Person()
            {
                Name = "Frank",
                Age = 30,
                Address = new Address()
                {
                    City = "KRS",
                    Street = "ABC"
                }
            };

            // Act
            var result = mapper.Map<Person, User>(source);

            // Assert
            result.Name.Should().Be(source.Name);
            result.Age.Should().Be(source.Age);
            result.Address.Should().NotBeNull();
            result.Address.City.Should().Be(source.Address.City);
        }

        private class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Address Address { get; set; }
        }

        private class Person
        {
            public string Name { get; set; }
            public int Age;
            public Address Address;
        }

        private class Address
        {
            public string Street { get; set; }
            public string City { get; set; }
        }
    }
}