using System.IO;

namespace Frank.Extensions.AzureStorage.FileShare
{
    public class ShareFileMetadata
    {
        public ShareFileMetadata(string name, string directoryPath, long fileSize)
        {
            Name = name;
            DirectoryPath = directoryPath;
            Extension = Path.GetExtension(name);
            FileSize = fileSize;
        }

        public string Name { get; }
        public string DirectoryPath { get; }
        public string Extension { get; }
        public long FileSize { get; }

        //public string GetFullPath() => Path.Combine(DirectoryPath, Name);
    }
}
