using System.IO;
using System.Threading;

namespace Frank.Libraries.Logging.FileLogging
{
    internal static class LogFileWriter
    {
        private static ReaderWriterLock _locker = new ReaderWriterLock();

        public static void WriteString(string value, string path)
        {
            try
            {
                _locker.AcquireWriterLock(int.MaxValue);
                File.AppendAllLines(path, new[] { value });
            }
            finally
            {
                _locker.ReleaseWriterLock();
            }
        }
    }
}
