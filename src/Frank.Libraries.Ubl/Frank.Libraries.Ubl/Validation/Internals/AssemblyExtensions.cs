using System.Reflection;

namespace Frank.Libraries.Ubl.Validation.Internals;

internal static class AssemblyExtensions
{
    public static IEnumerable<string> GetManifestResourceNames(this Assembly assembly, params string[] pathSegments)
    {
        var assemblyName = assembly.GetAssemblyName();
        var path = $"{assemblyName}.{string.Join(".", pathSegments)}";
        var resourceNames = assembly.GetManifestResourceNames();
        var xsdNames = resourceNames.Where(x => x.StartsWith(path, StringComparison.Ordinal));

        return xsdNames;
    }

    public static string GetAssemblyName(this Assembly assembly)
        => assembly.GetName()
                   .Name
           ?? throw new InvalidOperationException("Assembly name is null");

    public static AssemblyResourceFile GetManifestResourceFile(this Assembly assembly, string path)
        => new(path,
               assembly.GetManifestResourceStream(path) ?? throw new InvalidOperationException($"Could not find resource: {path}"));

    public static IEnumerable<AssemblyResourceFile> GetManifestResourceFile(this Assembly assembly)
    {
        var assemblyName = assembly.GetName()
                                   .Name;
        var resourceNames = assembly.GetManifestResourceNames();
        var xsdNames = resourceNames.Where(x =>
                                               x.Contains(assemblyName, StringComparison.Ordinal) && x.EndsWith(".xsd", StringComparison.Ordinal));
        return xsdNames.Select(x =>
                                   new AssemblyResourceFile(x,
                                                            assembly.GetManifestResourceStream(x) ?? throw new InvalidOperationException()));
    }

    public static Stream GetManifestResourceStream(this Assembly assembly, Uri uri)
    {
        var assemblyName = assembly.GetName()
                                   .Name;
        var path = string.Join(".", assemblyName, uri.Segments);
        var stream = assembly.GetManifestResourceStream(path);
        return stream ?? throw new InvalidOperationException($"Could not find resource: {path}");
    }
}