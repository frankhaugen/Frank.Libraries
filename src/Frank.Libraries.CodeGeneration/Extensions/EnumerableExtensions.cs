using System;
using System.Collections.Generic;
using System.Linq;

namespace Frank.Libraries.CodeGeneration.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<string> ToStrings<T>(this IEnumerable<T> source)
        {
            var output = new List<string>();

            foreach (var value in source)
            {
                output.TryAdd(value!.ToString());
            }

            return output;
        }

        public static IEnumerable<T> DoForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null || !source.Any())
            {
                return source;
            }

            foreach (var value in source)
            {
                if (value == null)
                {
                    continue;
                }

                action.Invoke(value);
            }

            return source;
        }
    }
}