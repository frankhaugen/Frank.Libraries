using Frank.Libraries.Extensions;

namespace TestingInfrastructure.Files;

public static class TestFiles
{
    private static readonly string _baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

    private static Dictionary<string, FileInfo> Files => new(new DirectoryInfo(_baseDirectory).EnumerateFiles("*", SearchOption.AllDirectories)
                                                                                              .DistinctBy(x => x.Name)
                                                                                              .ToDictionary(x => Path.GetFileName(x.Name.ToLowerInvariant()), x => x));

    public static string IrcErrorMessages => Find("IrcErrorMessages.json")
        .ReadAllText();

    private static string GetPath(string filename) => Path.Combine(_baseDirectory, filename);
    private static FileInfo GetFile(string filename) => new(GetPath(filename));

    public static FileInfo Find(string fileName) => Files.GetValueOrDefault(Path.GetFileName(fileName)
                                                                                .ToLowerInvariant());
}