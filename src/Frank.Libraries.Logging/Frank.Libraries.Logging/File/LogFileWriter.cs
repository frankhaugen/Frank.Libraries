namespace Frank.Libraries.Logging.File;

internal static class LogFileWriter
{
    private static readonly ReaderWriterLock _locker = new();

    public static void WriteString(string value, string path)
    {
        var directoryPath = Path.GetDirectoryName(path) ?? "";

        try
        {
            _locker.AcquireWriterLock(int.MaxValue);

            if (!string.IsNullOrWhiteSpace(directoryPath) && !Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!System.IO.File.Exists(path))
            {
                //System.IO.File.
            }

            System.IO.File.AppendAllLines(path, new[] { value });
        }
        finally
        {
            _locker.ReleaseWriterLock();
        }
    }
}