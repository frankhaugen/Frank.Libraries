using FluentAssertions;
using Frank.Libraries.DependencyInjection.Interfaces;
using Frank.Libraries.DependencyInjection.Statics;
using Xunit;

namespace Frank.Libraries.Tests.DependencyInjection
{
    public class ContainerTests
    {
        [Fact]
        public void StaticContainerTest()
        {
            // Arrange
            var name = "Frank";
            var option = new Option { Name = name };
            IocContainer.AddOption(nameof(Option), option);
            var service = new Service();
            IocContainer.AddService(service);

            // Act
            var serviceResult = IocContainer.GetService<Service>();
            var optionResult = IocContainer.GetOption<Option>(nameof(Option));
            serviceResult.SetValue(name);

            // Assert
            serviceResult.GetName()
                         .Should()
                         .Be(name);
            optionResult.Name = "NotFrank";
            serviceResult.GetName()
                         .Should()
                         .Be(optionResult.Name);
            serviceResult.SetValue(name);

            var serviceResult2 = IocContainer.GetService<Service>();
            serviceResult2.GetValue()
                          .Should()
                          .Be(name);
        }

        private class Option : IOption
        {
            public string? Name { get; set; }
        }

        private class Service : IService
        {
            private readonly Option _option;
            private string _value;

            public Service()
            {
                _value = "Initial";
                _option = IocContainer.GetOption<Option>(nameof(Option));
            }

            public void SetValue(string value)
            {
                _value = value;
            }

            public string GetValue()
            {
                return _value;
            }

            public string? GetName() => _option.Name;
        }
    }
}