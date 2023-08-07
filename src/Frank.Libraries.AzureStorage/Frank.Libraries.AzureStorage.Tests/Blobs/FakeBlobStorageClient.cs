using Frank.Libraries.AzureStorage.Blob;

namespace Frank.Libraries.AzureStorage.Tests.Blobs;

public class FakeBlobStorageClient : IBlobStorageClient
{
    private readonly Dictionary<string, ReadOnlyMemory<byte>> _blobs = new();

    public Task UploadAsync(BlobReference blobReference, ReadOnlyMemory<byte> memory, CancellationToken cancellationToken)
    {
        _blobs[$"{blobReference.ContainerName}:{blobReference.BlobName}"] = memory;
        return Task.CompletedTask;
    }

    public Task<ReadOnlyMemory<byte>> DownloadAsync(BlobReference blobReference, CancellationToken cancellationToken)
    {
        if (_blobs.TryGetValue($"{blobReference.ContainerName}:{blobReference.BlobName}", out var memory))
            return Task.FromResult(memory);
        else
            throw new ArgumentException("Blob not found");
    }
}