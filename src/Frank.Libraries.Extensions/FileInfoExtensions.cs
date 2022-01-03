using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Frank.Libraries.Extensions;

public static class FileInfoExtensions
{
    public static string ReadAllText(this FileInfo value) => File.ReadAllText(value.FullName);
    public static bool HasContent(this FileInfo value) => File.Exists(value.FullName) && File.ReadAllText(value.FullName).Any();
    public static byte[] ReadAllBytes(this FileInfo value) => File.ReadAllBytes(value.FullName);

    public static List<string> ReadAllLines(this FileInfo value) => File.ReadAllLines(value.FullName).ToList();

    public static async Task WriteAllTextAsync(this FileInfo file, string value, bool overwrite = false) => await File.WriteAllTextAsync(file.FullName, value);
    public static async Task WriteAllLinesAsync(this FileInfo file, IEnumerable<string> values, bool overwrite = false) => await File.WriteAllLinesAsync(file.FullName, values);
    public static async Task WriteAllBytesAsync(this FileInfo file, byte[] value, bool overwrite = false) => await File.WriteAllBytesAsync(file.FullName, value);

    private static async Task WriteTextAsync(FileInfo file, string value, bool overwrite = false)
    {
        if (file.HasContent() && !overwrite)
        {
            return;
        }
        await File.WriteAllTextAsync(file.FullName, value);
    }

    private static async Task WriteLinesAsync(FileInfo file, IEnumerable<string> values, bool overwrite = false)
    {
        if (file.HasContent() && !overwrite)
        {
            return;
        }
        await File.WriteAllLinesAsync(file.FullName, values);
    }

    private static async Task WriteBytesAsync(FileInfo file, byte[] value, bool overwrite = false)
    {
        if (file.HasContent() && !overwrite)
        {
            return;
        }
        await File.WriteAllBytesAsync(file.FullName, value);
    }


    public static async Task<string> ReadAllTextAsync(this FileInfo value) => await File.ReadAllTextAsync(value.FullName);
    public static async Task<byte[]> ReadAllBytesAsync(this FileInfo value) => await File.ReadAllBytesAsync(value.FullName);
    public static async Task<List<string>> ReadAllLinesAsync(this FileInfo value) => (await File.ReadAllLinesAsync(value.FullName)).ToList();
}