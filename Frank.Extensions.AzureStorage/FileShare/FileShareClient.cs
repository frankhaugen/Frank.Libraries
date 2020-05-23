using Azure.Storage.Files.Shares;
using Frank.Extensions.AzureStorage.FileShare.Exceptions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Frank.Extensions.AzureStorage.FileShare
{
    public class FileShareClient : IFileShareClient
    {
        private readonly ShareClient _shareClient;
        private readonly IList<ShareFileMetadata> _shareFiles;
        private readonly IList<string> _shareDirectories;

        public FileshareUploadException? UploadException { get; private set; }
        public FileshareDownloadException? DownloadException { get; private set; }

        public FileShareClient(IOptions<FileShareConfiguration> options)
        {
            _shareClient = new ShareClient(options.Value.ConnectionString, options.Value.ShareName);
            _shareFiles = new List<ShareFileMetadata>();
            _shareDirectories = new List<string>();
            Initialize();
        }

        public FileShareClient(FileShareConfiguration configuration)
        {
            _shareClient = new ShareClient(configuration.ConnectionString, configuration.ShareName);
            _shareFiles = new List<ShareFileMetadata>();
            _shareDirectories = new List<string>();
            Initialize();
        }

        public FileShareClient(string connectionString, string shareName)
        {
            _shareClient = new ShareClient(connectionString, shareName);
            _shareFiles = new List<ShareFileMetadata>();
            _shareDirectories = new List<string>();
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

                _shareDirectories.Add(HttpUtility.UrlDecode(dir.Path));
                foreach (var item in dir.GetFilesAndDirectories())
                {
                    // Keep walking down directories
                    if (item.IsDirectory)
                    {
                        remaining.Enqueue(dir.GetSubdirectoryClient(item.Name));
                    }
                    else
                    {
                        if (item.FileSize != null) _shareFiles.Add(new ShareFileMetadata(item.Name, HttpUtility.UrlDecode(dir.Path), item.FileSize.Value));
                    }
                }
            }
        }

        public bool Exist(string filename)
        {
            return _shareFiles.Any(x => string.Equals(x.Name, Path.GetFileNameWithoutExtension(filename), StringComparison.InvariantCultureIgnoreCase));
        }

        public IEnumerable<ShareFileMetadata> Search(string filename)
        {
            return _shareFiles.Where(x => x.Name.ToLowerInvariant().Contains(Path.GetFileNameWithoutExtension(filename)));
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

        public IEnumerable<string>? DirectoryItems
        {
            get
            {
                if (_shareDirectories == null || !_shareDirectories.Any())
                {
                    Initialize();
                }

                return _shareDirectories;
            }
        }

        public bool TryDownload(ShareFileMetadata shareFile, out byte[] fileData)
        {
            try
            {
                fileData = DownloadAsync(shareFile).GetAwaiter().GetResult();
                return true;
            }
            catch (Exception e)
            {
                DownloadException = new FileshareDownloadException($"The file '{shareFile.Name}{shareFile.Extension}' could not be downloaded", e);
                fileData = null!;
                return false;
            }
        }

        public async Task<byte[]> DownloadAsync(ShareFileMetadata shareFile)
        {
            var directory = _shareClient.GetDirectoryClient(shareFile.GetEncodedDirectoryPath);
            var download = await directory.GetFileClient(shareFile.Name).DownloadAsync();
            var stream = new MemoryStream();
            try
            {
                await download.Value.Content.CopyToAsync(stream);
                return stream.ToArray();
            }
            catch (Exception e)
            {
                throw new FileshareDownloadException($"The file '{shareFile.Name}{shareFile.Extension}' could not be downloaded", e);
            }
        }

        public async Task<bool> TryUpload(byte[] fileData, string filename, string directoryPath)
        {
            try
            {
                await UploadAsync(fileData, filename, directoryPath);
                return true;
            }
            catch (Exception e)
            {
                UploadException = new FileshareUploadException($"The file '{filename}' could not be uploaded", e);
                return false;
            }
        }

        public async Task UploadAsync(byte[] fileData, string filename, string directoryPath)
        {
            var stream = new MemoryStream(fileData);
            var directory = _shareClient.GetDirectoryClient(directoryPath);
            try
            {
                await directory.GetFileClient(filename).UploadAsync(stream);
            }
            catch (Exception e)
            {
                throw new FileshareUploadException($"The file '{filename}' could not be uploaded", e);
            }
        }
    }
}