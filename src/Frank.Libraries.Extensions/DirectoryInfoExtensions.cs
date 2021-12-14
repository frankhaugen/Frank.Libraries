using System;
using System.IO;

namespace Frank.Libraries.Extensions;

public static class DirectoryInfoExtensions
{
    public static DirectoryInfo GetSolutionDirectory(this DirectoryInfo _) => new DirectoryInfo(AppContext.BaseDirectory).Parent?.Parent?.Parent?.Parent ?? new DirectoryInfo(AppContext.BaseDirectory);
    public static DirectoryInfo GetSubDirectory(this DirectoryInfo directory, string name) => new(Path.Combine(directory.FullName, name));
}