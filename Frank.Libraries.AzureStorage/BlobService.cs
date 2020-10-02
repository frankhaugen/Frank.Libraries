using Azure.Storage.Blobs;
using Microsoft.Extensions.Options;
using System.IO;
using System.Threading.Tasks;

namespace Frank.Libraries.AzureStorage
{
    public class BlobService
    {
        private readonly BlobConfiguration _options;
        private readonly BlobContainerClient _blobContainerClient;

        public BlobService(IOptions<BlobConfiguration> options)
        {
            _options = options.Value;
            _blobContainerClient = new BlobContainerClient(_options.ConnectionString, _options.ContainerName);
        }

        public async Task<byte[]> DownloadAsync(string blobName)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var memoryStream = new MemoryStream();
            await blobClient.DownloadToAsync(memoryStream);
            return memoryStream.ToArray();
        }

        public async Task<bool> UploadAsync(string blobName, byte[] blob)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var memoryStream = new MemoryStream(blob) { Position = 0 };
            var result = await blobClient.UploadAsync(memoryStream);
            return result.GetRawResponse().Status < 400;
        }

        public async Task<bool> UpdateAsync(string blobName, byte[] blob)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var memoryStream = new MemoryStream(blob) { Position = 0 };
            var result = await blobClient.UploadAsync(memoryStream, true);
            return result.GetRawResponse().Status < 400;
        }

        public async Task<bool> DeleteAsync(string blobName)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var result = await blobClient.DeleteIfExistsAsync();
            return result.GetRawResponse().Status < 400;
        }

        public async Task<bool> ExistAsync(string blobName)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var result = await blobClient.ExistsAsync();
            return result.GetRawResponse().Status < 400;
        }

        public async Task<bool> CreateContainerAsync()
        {
            var result = await _blobContainerClient.CreateIfNotExistsAsync();
            return result.GetRawResponse().Status < 400;
        }

        public async Task<bool> ContainerExistAsync()
        {
            var result = await _blobContainerClient.ExistsAsync();
            return result.GetRawResponse().Status < 400;
        }
    }
}
