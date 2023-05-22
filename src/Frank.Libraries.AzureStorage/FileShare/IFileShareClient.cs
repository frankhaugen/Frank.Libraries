namespace Frank.Libraries.AzureStorage.FileShare;

public interface IFileShareClient
{
    Task<Stream> DownloadAsync(FileShareReference reference);
    Task UploadAsync(Stream stream, FileShareReference reference);
}