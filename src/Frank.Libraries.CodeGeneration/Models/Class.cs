using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Models;

public record Class
{
    public Class(string name, string @namespace = "#NAMESPACE#", bool hasInterface = false, string? extender = null, bool isStatic = false)
    {
        Name = name;
        IsStatic = isStatic;
        Properties = new Dictionary<string, Type>();
        Namespace = @namespace;
        Methods = new List<Method>();
        UsingNamespaces = new List<string>();
        Constructor = new Method(new MethodSignature(Name));
        Extender = extender;

        if (hasInterface)
        {
            if (string.IsNullOrWhiteSpace(Extender))
            {
                Extender = "I" + Name;
            }
            else
            {
                Extender += $", I{Name}";
            }
        }
    }

    public string Name { get; }
    public bool IsStatic { get; }
    public string Namespace { get; private set; }
    public string FullName => Namespace + "." + Name;
    public List<Method> Methods { get; }
    public List<string> UsingNamespaces { get; }
    public Dictionary<string, Type> Properties { get; }
    public Method Constructor { get; private set; }
    public string? Extender { get; }

    public void SetNamespace(string @namespace) => Namespace = @namespace;

    public void SetConstructor(Method method) => Constructor = method;

    public void AddMethods(List<Method> methods) => Methods.AddRange(methods);

    public void AddMethod(Method method)
    {
        if (!UsingNamespaces.Contains($"using {method.Signature.ReturnType?.Namespace.FallbackIfNull("System")};"))
        {
            AddUsingNamespace(method.Signature.ReturnType?.Namespace.FallbackIfNull("")!);
        }

        Methods.Add(method);
    }

    public void AddUsingNamespace(List<string> namespaces) => namespaces.ForEach(AddUsingNamespace);
    public void AddUsingNamespace(Type type) => AddUsingNamespace(type.Namespace.FallbackIfNull("System"));
    public void AddUsingNamespace(List<Type> types) => types.ForEach(AddUsingNamespace);
    public void AddUsingNamespace(string @namespace) => UsingNamespaces.Add($"using {@namespace.FallbackIfEmpty("System")};");

    public void AddProperties(Dictionary<string, Type> properties) => properties.DoForEach(x => AddProperty(x.Key, x.Value));

    public void AddProperty(string name, Type type)
    {
        if (!UsingNamespaces.Contains($"using {type.Namespace.FallbackIfNull("System")};"))
        {
            AddUsingNamespace(type.Namespace.FallbackIfNull("System"));
        }

        Properties.Add(name, type);
    }

    /// <inheritdoc />
    public string CreateInterface() => new StringBuilder()
                                       .AppendIf(string.Join("\n", UsingNamespaces.Order()), UsingNamespaces.Any())
                                       .AppendIndentedLine(0, $"namespace {Namespace}")
                                       .AppendIndentedLine(0, "{")
                                       .AppendIndentedLine(1, $"public interface I{Name}")
                                       .AppendIndentedLine(1, "{")
                                       .AppendIndentedLines(Properties.Select(x => $"public {x.Value} {x.Key} " + "{ get; set; }")
                                                                      .ToList(), 2)
                                       .AppendIndentedLines(Methods.Select(x => x.Signature)
                                                                   .Select(x => x.ToString()
                                                                                 .Remove("async ")
                                                                                 .Remove("public ")
                                                                                 .ToString()
                                                                                + ";")
                                                                   .ToList()
                                                                   .FallbackIfNull(new List<string>()))
                                       .AppendIndentedLine(1, "}")
                                       .AppendIndentedLine(0, "}")
                                       .ToString();

    /// <inheritdoc />
    public override string ToString() => new StringBuilder()
                                         .AppendIf(string.Join("\n", UsingNamespaces.Order()), UsingNamespaces.Any())
                                         .AppendIndentedLine(0, $"namespace {Namespace}")
                                         .AppendIndentedLine(0, "{")
                                         .AppendIndentedLine(1, $"public {(IsStatic ? "static" : "")} class {Name}")
                                         .AppendIf($" : {Extender}", !string.IsNullOrWhiteSpace(Extender))
                                         .AppendIndentedLine(1, "{")
                                         .AppendIndentedLines(Properties.Select(x => $"public {x.Value} {x.Key} " + "{ get; set; }")
                                                                        .ToList(), 2)
                                         .AppendIndentedLine(0, Constructor.ToString()
                                                                           .Replace(" void", ""))
                                         .AppendIndentedLines(Methods.ToStrings()
                                                                     .ToList())
                                         .AppendIndentedLine(1, "}")
                                         .AppendIndentedLine(0, "}")
                                         .ToString();

    public void ToFile(DirectoryInfo directory, bool overwrite = false)
    {
        if (!directory.Exists)
        {
            directory.Create();
        }

        var path = Path.Combine(directory.FullName, Name + ".cs");

        if (File.Exists(path) && !overwrite)
        {
            return;
        }

        File.WriteAllText(path, ToString());
    }
}