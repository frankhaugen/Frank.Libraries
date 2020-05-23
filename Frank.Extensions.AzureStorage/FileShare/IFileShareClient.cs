using System.Collections.Generic;
using System.Threading.Tasks;
using Frank.Extensions.AzureStorage.FileShare.Exceptions;

namespace Frank.Extensions.AzureStorage.FileShare
{
    public interface IFileShareClient
    {
        FileshareUploadException? UploadException { get; }
        FileshareDownloadException? DownloadException { get; }
        IEnumerable<ShareFileMetadata>? FileItems { get; }
        IEnumerable<string>? DirectoryItems { get; }
        bool TryDownload(ShareFileMetadata shareFile, out byte[] fileData);
        Task<byte[]> DownloadAsync(ShareFileMetadata shareFile);
        Task<bool> TryUpload(byte[] fileData, string filename, string directoryPath);
        Task UploadAsync(byte[] fileData, string filename, string directoryPath);
    }
}
