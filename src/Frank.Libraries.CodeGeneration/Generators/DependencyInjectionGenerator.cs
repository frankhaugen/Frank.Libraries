using System.Collections.Generic;
using System.IO;
using System.Linq;
using Frank.Libraries.CodeGeneration.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public class DependencyInjectionGenerator
    {
        private readonly Class _class;
        private readonly List<Class> _classes;

        public DependencyInjectionGenerator(Dictionary<Class, ServiceLifetime> classes, string extensionMethodName = "AddGeneratedDependencies")
        {
            var signature = new MethodSignature($"{extensionMethodName}", arguments: new List<Argument>() { new(typeof(IServiceCollection), "services", isExtension: true) });
            var lines = classes.Select(x => GetAddServiceCodeLine(x.Value, x.Key.Name)).ToList();
            var method = new Method(signature, lines);

            _classes = classes.Keys.ToList();
            _class = new Class("ServiceCollectionExtensions", isStatic: true);
            _class.AddMethod(method);
        }

        private CodeLine GetAddServiceCodeLine(ServiceLifetime lifetime, string className)
        {
            return new CodeLine($"services.Add{lifetime}<I{className},{className}>()");
        }

        public void ToFiles(DirectoryInfo directory)
        {
            if (!directory.Exists)
            {
                directory.Create();
            }

            foreach (var @class in _classes)
            {
                File.WriteAllText(Path.Combine(directory.FullName, $"{@class.Name}.cs"), @class.ToString());
                File.WriteAllText(Path.Combine(directory.FullName, $"I{@class.Name}.cs"), @class.CreateInterface());
            }

            File.WriteAllText(Path.Combine(directory.FullName, $"{_class.Name}.cs"), _class.ToString());
        }
    }
}