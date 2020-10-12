using System.Collections.Generic;
using System.Reflection;
using Frank.Libraries.Testing.CodeRules.Interfaces;

namespace Frank.Libraries.Testing.CodeRules
{
    public static class AssertRule
    {
        public static string AdheresToRule<T>(ICodeRule rule, T type) where T : class
        {
            var assembly = Assembly.GetCallingAssembly();
            var files = assembly.GetFiles();
            //var lines = File.ReadAllLines(type.GetType().AssemblyQualifiedName);
            //if (rule.IgnoreComments)
            //lines = lines.Where(x => !x.Contains("//")).ToArray();
            //var codelines = lines.Where(x => x.Trim().Contains(";"));
            //return $"{lines.Length},{codelines.Count()}";

            var output = new List<string>();

            //foreach (var file in files)
            //{
            //    using (var streamReader = new StreamReader(file))
            //    {
            //        output.Add(file.Name);
            //    }
            //}

            return string.Join(", ", output);
        }
    }
}
