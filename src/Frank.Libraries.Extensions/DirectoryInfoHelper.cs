namespace Frank.Libraries.Extensions;

public static class DirectoryInfoHelper
{
    public static DirectoryInfo GetSolutionDirectory() => new DirectoryInfo(AppContext.BaseDirectory).Parent?.Parent?.Parent?.Parent ?? new DirectoryInfo(AppContext.BaseDirectory);
}