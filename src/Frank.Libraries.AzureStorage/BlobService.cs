using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.AzureStorage;

/// <summary>
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
    ///     Download a file
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
    ///     Upload a file
    /// </summary>
    /// <param name="blobName"></param>
    /// <param name="blob"></param>
    /// <returns></returns>
    public async Task<bool> UploadAsync(string blobName, byte[] blob)
    {
        var blobClient = _blobContainerClient.GetBlobClient(blobName);
        var memoryStream = new MemoryStream(blob) { Position = 0 };
        var result = await blobClient.UploadAsync(memoryStream);
        return result.GetRawResponse()
                     .Status
               < 400;
    }

    /// <summary>
    ///     Update a file in the <paramref name="blob" />
    /// </summary>
    /// <param name="blobName"></param>
    /// <param name="blob"></param>
    /// <returns></returns>
    public async Task<bool> UpdateAsync(string blobName, byte[] blob)
    {
        var blobClient = _blobContainerClient.GetBlobClient(blobName);
        var memoryStream = new MemoryStream(blob) { Position = 0 };
        var result = await blobClient.UploadAsync(memoryStream, true);
        return result.GetRawResponse()
                     .Status
               < 400;
    }

    /// <summary>
    ///     Deletes a blob
    /// </summary>
    /// <param name="blobName"></param>
    /// <returns></returns>
    public async Task<bool> DeleteAsync(string blobName)
    {
        var blobClient = _blobContainerClient.GetBlobClient(blobName);
        var result = await blobClient.DeleteIfExistsAsync();
        return result.GetRawResponse()
                     .Status
               < 400;
    }

    /// <summary>
    ///     Checks to see if the blob exists
    /// </summary>
    /// <param name="blobName"></param>
    /// <returns></returns>
    public async Task<bool> ExistAsync(string blobName)
    {
        var blobClient = _blobContainerClient.GetBlobClient(blobName);
        var result = await blobClient.ExistsAsync();
        return result.GetRawResponse()
                     .Status
               < 400;
    }

    /// <summary>
    ///     Returns a list of blob-names matching the parameters
    /// </summary>
    /// <param name="searchParameters">What to search for, (wildcard not supported)</param>
    /// <param name="ignoreCharacterSequence"></param>
    /// <param name="stringComparison"></param>
    /// <returns></returns>
    public IEnumerable<string> Search(string? searchParameters = null, bool ignoreCharacterSequence = false, StringComparison stringComparison = StringComparison.InvariantCultureIgnoreCase)
    {
        var blobHierarchyItems = _blobContainerClient.GetBlobsByHierarchy();

        if (blobHierarchyItems == null || !blobHierarchyItems.Any())
        {
            return new List<string>();
        }

        var blobNames = blobHierarchyItems.Select(blob => blob.Blob.Name)
                                          .OrderBy(x => x);

        if (!blobNames.Any())
        {
            return new List<string>();
        }

        if (string.IsNullOrWhiteSpace(searchParameters))
        {
            return blobNames;
        }

        var output = blobNames.Where(blobName => blobName.Contains(searchParameters, stringComparison))
                              .ToList();

        if (ignoreCharacterSequence)
        {
            output.AddRange(from blobName in blobNames
                            let characters = blobName.ToLowerInvariant()
                                                     .ToCharArray()
                            let searchCharacters = searchParameters.ToLowerInvariant()
                                                                   .ToCharArray()
                            let matchingCharacterCount = searchCharacters.Count(characters.Contains)
                            where matchingCharacterCount == searchCharacters.Length
                            select blobName);
        }

        return output;
    }

    /// <summary>
    ///     Create a container, (will not overwrite existing
    /// </summary>
    /// <returns></returns>
    public async Task<bool> CreateContainerAsync()
    {
        var result = await _blobContainerClient.CreateIfNotExistsAsync();
        return result.GetRawResponse()
                     .Status
               < 400;
    }

    /// <summary>
    ///     Checks to see if the container specified exist
    /// </summary>
    /// <returns></returns>
    public async Task<bool> ContainerExistAsync()
    {
        var result = await _blobContainerClient.ExistsAsync();
        return result.GetRawResponse()
                     .Status
               < 400;
    }
}