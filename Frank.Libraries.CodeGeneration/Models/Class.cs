using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Models
{
    public record Class
    {
        public string Name { get; }
        public string Namespace { get; }
        public List<Method> Methods { get; }
        public List<string> UsingNamespaces { get; }
        public Dictionary<string, Type> Properties { get; }
        public Method Constructor { get; private set; }
        public string? Extender { get; }

        public Class(string name, string @namespace = "#NAMESPACE#", string? extender = null)
        {
            Name = name;
            Properties = new Dictionary<string, Type>();
            Namespace = @namespace;
            Methods = new List<Method>();
            UsingNamespaces = new List<string>();
            Constructor = new Method(new MethodSignature(Name));
            Extender = extender;
        }

        public void SetConstructor(Method method) => Constructor = method;

        public void AddMethods(List<Method> methods) => Methods.AddRange(methods);
        public void AddMethod(Method method)
        {
            if (!UsingNamespaces.Contains($"using {method.Signature.ReturnType?.Namespace.FallbackIfNull("System")};"))
                AddUsingNamespace(method.Signature.ReturnType?.Namespace.FallbackIfNull("")!);

            Methods.Add(method);
        }

        public void AddUsingNamespaces(List<string> namespaces) => namespaces.ForEach(AddUsingNamespace);
        public void AddUsingNamespace(string @namespace) => UsingNamespaces.Add($"using {@namespace};");

        public void AddProperties(Dictionary<string, Type> properties) => properties.DoForEach(x => AddProperty(x.Key, x.Value));
        public void AddProperty(string name, Type type)
        {
            if (!UsingNamespaces.Contains($"using {type.Namespace.FallbackIfNull("System")};"))
                AddUsingNamespace(type.Namespace.FallbackIfNull(""));

            Properties.Add(name, type);
        }

        /// <inheritdoc/>
        public override string ToString() => new StringBuilder()
            .AppendIf(string.Join('\n', UsingNamespaces.ToStrings()), UsingNamespaces.Any())
            .AppendIndentedLine(0, $"namespace {Namespace}")
            .AppendIndentedLine(0, "{")
            .AppendIndentedLine(1, $"public class {Name}").AppendIf($" : {Extender}", !string.IsNullOrWhiteSpace(Extender))
            .AppendIndentedLine(1, "{")
            .AppendIndentedLines(Properties.Select(x => $"public {x.Value} {x.Key} " + "{ get; set; }").ToList(), 2)
            .AppendIndentedLine(0, Constructor.ToString().Replace(" void", ""))
            .AppendIndentedLines(Methods.ToStrings().ToList(), 0)
            .AppendIndentedLine(1, "}")
            .AppendIndentedLine(0, "}")
            .ToString();

        public void ToFile(DirectoryInfo directory)
        {
            if (!directory.Exists)
            {
                directory.Create();
            }
            File.WriteAllText(Path.Combine(directory.FullName, Name + ".cs"), ToString());
        }
    }
}