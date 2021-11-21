using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Libraries.Extensions
{
    public static class DecimalExtensions
    {
        public static float ToFloat(this decimal value) => Convert.ToSingle(value);

        public static double ToDouble(this decimal value) => Convert.ToDouble(value);

        public static int ToInteger(this decimal value) => Convert.ToInt32(Math.Round(value, 0, MidpointRounding.AwayFromZero));

        public static decimal ToPowerOf(this decimal value, int powerOf)
        {
            if (powerOf < 1) return 0.0m;
            if (powerOf == 1) return value;

            var result = value;

            for (var i = 1; i < powerOf; i++)
            {
                result *= value;
            }

            return result;
        }
    }

    public static class FileInfoExtensions
    {
        public static string ReadAllText(this FileInfo value) => File.ReadAllText(value.FullName);
        public static byte[] ReadAllBytes(this FileInfo value) => File.ReadAllBytes(value.FullName);

        public static List<string> ReadAllLines(this FileInfo value) => File.ReadAllLines(value.FullName)
                                                                            .ToList();

        public static async Task<string> ReadAllTextAsync(this FileInfo value) => await File.ReadAllTextAsync(value.FullName);
        public static async Task<byte[]> ReadAllBytesAsync(this FileInfo value) => await File.ReadAllBytesAsync(value.FullName);
        public static async Task<List<string>> ReadAllLinesAsync(this FileInfo value) => (await File.ReadAllLinesAsync(value.FullName)).ToList();
    }
}