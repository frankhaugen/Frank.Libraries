namespace Frank.Libraries.AzureStorage.Blob;

public class BlobReference
{
    public BlobReference(string containerName, string blobName)
    {
        ContainerName = containerName;
        BlobName = blobName;
        BlobReferenceGuards.GuardContainerName(ContainerName);
        BlobReferenceGuards.GuardBlobName(BlobName);
    }

    public string ContainerName { get; }
    public string BlobName { get; }
}