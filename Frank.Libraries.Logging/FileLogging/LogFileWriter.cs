using System.IO;
using System.Threading;

namespace Frank.Libraries.Logging.FileLogging
{
    internal static class LogFileWriter
    {
        private static ReaderWriterLock locker = new ReaderWriterLock();

        public static void WriteString(string value, string path)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                File.AppendAllLines(path, new[] { value });
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
        }
    }
}
