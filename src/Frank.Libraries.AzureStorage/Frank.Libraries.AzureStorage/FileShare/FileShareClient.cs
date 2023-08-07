using Azure.Storage.Files.Shares;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.AzureStorage.FileShare;

public class FileShareClient : IFileShareClient
{
    private readonly IOptions<FileShareConfiguration> _options;

    public FileShareClient(IOptions<FileShareConfiguration> options) => _options = options;

    public async Task<Stream> DownloadAsync(FileShareReference reference)
    {
        var fileClient = await CreateClient(reference);
        var download = await fileClient.DownloadAsync();
        return download.Value.Content;
    }

    public async Task UploadAsync(Stream stream, FileShareReference reference)
    {
        var fileClient = await CreateClient(reference);
        await fileClient.UploadAsync(stream);
    }

    private async Task<ShareFileClient> CreateClient(FileShareReference reference)
    {
        var client = new ShareClient(_options.Value.ConnectionString, _options.Value.ShareName);
        var directoryClient = client.GetDirectoryClient(reference.DirectoryPath);
        var fileClient = directoryClient.GetFileClient(reference.Filename);
        return fileClient;
    }
}