using Azure.Storage.Files.Shares;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;

namespace Frank.Extensions.AzureStorage.FileShare
{
    public class FileShareClient
    {
        private readonly ShareClient _shareClient;
        private readonly IList<ShareFileMetadata> _shareFiles;

        public FileShareClient(IOptions<FileShareConfiguration> options)
        {
            _shareClient = new ShareClient(options.Value.ConnectionString, options.Value.ShareName);
            _shareFiles = new List<ShareFileMetadata>();
            Initialize();
        }

        private void Initialize()
        {
            _shareClient.CreateIfNotExists();

            // Track the remaining directories to walk, starting from the root
            var remaining = new Queue<ShareDirectoryClient>();
            remaining.Enqueue(_shareClient.GetRootDirectoryClient());
            while (remaining.Count > 0)
            {
                // Get all of the next directory's files and subdirectories
                var dir = remaining.Dequeue();
                foreach (var item in dir.GetFilesAndDirectories())
                {
                    // Keep walking down directories
                    if (item.IsDirectory)
                    {
                        remaining.Enqueue(dir.GetSubdirectoryClient(item.Name));
                    }
                    else
                    {
                        if (item.FileSize != null) _shareFiles.Add(new ShareFileMetadata(item.Name, dir.Uri.AbsolutePath, item.FileSize.Value));
                    }
                }
            }
        }

        public IEnumerable<ShareFileMetadata>? FileItems
        {
            get
            {
                if (_shareFiles == null || !_shareFiles.Any())
                {
                    Initialize();
                }

                return _shareFiles;
            }
        }
    }
}