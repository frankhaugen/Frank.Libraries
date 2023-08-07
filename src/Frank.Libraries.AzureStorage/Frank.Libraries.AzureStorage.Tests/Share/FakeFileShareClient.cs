using Frank.Libraries.AzureStorage.FileShare;

namespace Frank.Libraries.AzureStorage.Tests.Share;

public class FakeFileShareClient : IFileShareClient
{
    private readonly Dictionary<string, MemoryStream> _files = new();

    public Task<Stream> DownloadAsync(FileShareReference reference)
    {
        if (_files.TryGetValue($"{reference.DirectoryPath}:{reference.Filename}", out var stream))
        {
            stream.Seek(0, SeekOrigin.Begin);
            return Task.FromResult<Stream>(stream);
        }
        else
        {
            throw new FileNotFoundException($"File not found: {reference}");
        }
    }

    public async Task UploadAsync(Stream stream, FileShareReference reference)
    {
        var memoryStream = new MemoryStream();
        await stream.CopyToAsync(memoryStream);
        _files[$"{reference.DirectoryPath}:{reference.Filename}"] = memoryStream;
    }
}