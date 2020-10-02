using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.AzureStorage
{
    /// <summary>
    /// 
    /// </summary>
    public class BlobService
    {
        private readonly BlobContainerClient _blobContainerClient;

        /// <summary>
        /// </summary>
        /// <param name="options"></param>
        public BlobService(IOptions<BlobConfiguration> options)
        {
            var configuration = options.Value;
            _blobContainerClient = new BlobContainerClient(configuration.ConnectionString, configuration.ContainerName);
        }

        /// <summary>
        /// Download a file
        /// </summary>
        /// <param name="blobName"></param>
        /// <returns></returns>
        public async Task<byte[]> DownloadAsync(string blobName)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var memoryStream = new MemoryStream();
            await blobClient.DownloadToAsync(memoryStream);
            return memoryStream.ToArray();
        }

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <param name="blobName"></param>
        /// <param name="blob"></param>
        /// <returns></returns>
        public async Task<bool> UploadAsync(string blobName, byte[] blob)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var memoryStream = new MemoryStream(blob) { Position = 0 };
            var result = await blobClient.UploadAsync(memoryStream);
            return result.GetRawResponse().Status < 400;
        }

        /// <summary>
        /// Update a file in the <paramref name="blob"/>
        /// </summary>
        /// <param name="blobName"></param>
        /// <param name="blob"></param>
        /// <returns></returns>
        public async Task<bool> UpdateAsync(string blobName, byte[] blob)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var memoryStream = new MemoryStream(blob) { Position = 0 };
            var result = await blobClient.UploadAsync(memoryStream, true);
            return result.GetRawResponse().Status < 400;
        }

        /// <summary>
        /// Deletes a blob
        /// </summary>
        /// <param name="blobName"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(string blobName)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var result = await blobClient.DeleteIfExistsAsync();
            return result.GetRawResponse().Status < 400;
        }

        /// <summary>
        /// Checks to see if the blob exists
        /// </summary>
        /// <param name="blobName"></param>
        /// <returns></returns>
        public async Task<bool> ExistAsync(string blobName)
        {
            var blobClient = _blobContainerClient.GetBlobClient(blobName);
            var result = await blobClient.ExistsAsync();
            return result.GetRawResponse().Status < 400;
        }

        /// <summary>
        /// Create a container, (will not overwrite existing
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CreateContainerAsync()
        {
            var result = await _blobContainerClient.CreateIfNotExistsAsync();
            return result.GetRawResponse().Status < 400;
        }

        /// <summary>
        /// Checks to see if the container specified exist
        /// </summary>
        /// <returns></returns>
        public async Task<bool> ContainerExistAsync()
        {
            var result = await _blobContainerClient.ExistsAsync();
            return result.GetRawResponse().Status < 400;
        }
    }
}
