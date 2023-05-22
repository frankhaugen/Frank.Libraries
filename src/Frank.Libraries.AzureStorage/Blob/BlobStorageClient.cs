using Azure.Storage.Blobs;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.AzureStorage.Blob;

public class BlobStorageClient : IBlobStorageClient
{
    private readonly IOptions<BlobStorageOptions> _options;
    private readonly SemaphoreSlim _containerSemaphore = new(1);

    public BlobStorageClient(IOptions<BlobStorageOptions> options) => _options = options;

    public async Task UploadAsync(BlobReference blobReference, ReadOnlyMemory<byte> memory, CancellationToken cancellationToken)
    {
        var blobClient = await CreateClientAsync(blobReference, cancellationToken);
        await blobClient.UploadAsync(new BinaryData(memory), true, cancellationToken);
    }

    public async Task<ReadOnlyMemory<byte>> DownloadAsync(BlobReference blobReference, CancellationToken cancellationToken)
    {
        var blobClient = await CreateClientAsync(blobReference, cancellationToken);
        var download = await blobClient.DownloadContentAsync(cancellationToken);
        return download.Value.Content;
    }

    private async Task<BlobClient> CreateClientAsync(BlobReference blobReference, CancellationToken cancellationToken)
    {
        var containerClient = new BlobContainerClient(_options.Value.ConnectionString, blobReference.ContainerName);
        await _containerSemaphore.WaitAsync(cancellationToken);
        try
        {
            await containerClient.CreateIfNotExistsAsync(cancellationToken: cancellationToken);
        }
        finally
        {
            _containerSemaphore.Release();
        }
        BlobClient blobClient = containerClient.GetBlobClient(blobReference.BlobName);
        return blobClient;
    }
}