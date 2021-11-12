using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Frank.Libraries.Extensions;
using Microsoft.Azure.Amqp.Framing;

namespace Frank.Libraries.Tests.TestingInfrastructure.Files
{
    public static class TestFiles
    {
        private static string _baseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
        private static string GetPath(string filename) => Path.Combine(_baseDirectory, filename);
        private static FileInfo GetFile(string filename) => new FileInfo(GetPath(filename));
        private static Dictionary<string, FileInfo> Files => new(new DirectoryInfo(_baseDirectory).EnumerateFiles("*", SearchOption.AllDirectories).DistinctBy(x => x.Name).ToDictionary(x => Path.GetFileName(x.Name.ToLowerInvariant()), x => x));

        public static FileInfo Find(string fileName) => Files.GetValueOrDefault(Path.GetFileName(fileName).ToLowerInvariant());

        public static string IrcErrorMessages => Find("IrcErrorMessages.json").ReadAllText();
    }
}