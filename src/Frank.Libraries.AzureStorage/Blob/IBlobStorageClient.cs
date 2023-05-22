namespace Frank.Libraries.AzureStorage.Blob;

public interface IBlobStorageClient
{
    Task UploadAsync(BlobReference blobReference, ReadOnlyMemory<byte> memory, CancellationToken cancellationToken);

    Task<ReadOnlyMemory<byte>> DownloadAsync(BlobReference blobReference, CancellationToken cancellationToken);
}