using System;
using System.IO;

namespace Frank.Libraries.Extensions;

public static class DirectoryInfoHelper
{
    public static DirectoryInfo GetSolutionDirectory() => new DirectoryInfo(AppContext.BaseDirectory).Parent?.Parent?.Parent?.Parent ?? new DirectoryInfo(AppContext.BaseDirectory);
}

public static class DirectoryInfoExtensions
{
    public static DirectoryInfo GetSubDirectory(this DirectoryInfo directory, string name) => new(Path.Combine(directory.FullName, name));
}