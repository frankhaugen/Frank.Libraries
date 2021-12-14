using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Libraries.Extensions;

public static class FileInfoExtensions
{
    public static string ReadAllText(this FileInfo value) => File.ReadAllText(value.FullName);
    public static byte[] ReadAllBytes(this FileInfo value) => File.ReadAllBytes(value.FullName);

    public static List<string> ReadAllLines(this FileInfo value) => File.ReadAllLines(value.FullName)
                                                                        .ToList();

    public static async Task WriteAllTextAsync(this FileInfo file, string value) => await File.WriteAllTextAsync(file.FullName, value);
    public static async Task WriteAllLinesAsync(this FileInfo file, IEnumerable<string> values) => await File.WriteAllLinesAsync(file.FullName, values);
    public static async Task WriteAllBytesAsync(this FileInfo file, byte[] value) => await File.WriteAllBytesAsync(file.FullName, value);

    public static async Task<string> ReadAllTextAsync(this FileInfo value) => await File.ReadAllTextAsync(value.FullName);
    public static async Task<byte[]> ReadAllBytesAsync(this FileInfo value) => await File.ReadAllBytesAsync(value.FullName);
    public static async Task<List<string>> ReadAllLinesAsync(this FileInfo value) => (await File.ReadAllLinesAsync(value.FullName)).ToList();
}