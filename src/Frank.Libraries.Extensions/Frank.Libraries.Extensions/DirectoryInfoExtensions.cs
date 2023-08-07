namespace Frank.Libraries.Extensions;

public static class DirectoryInfoExtensions
{
    public static DirectoryInfo GetSubDirectory(this DirectoryInfo directory, string name) => new(Path.Combine(directory.FullName, name));
}