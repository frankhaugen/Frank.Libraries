using Frank.Libraries.AzureStorage.Blob;
using Frank.Libraries.AzureStorage.FileShare;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.AzureStorage.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlobStorage(this IServiceCollection services, string connectionString)
    {
        services.Configure<BlobStorageOptions>(options => options.ConnectionString = connectionString);
        services.AddTransient<IBlobStorageClient, BlobStorageClient>();
        return services;
    }

    public static IServiceCollection AddFileShare(this IServiceCollection services, string connectionString, string shareName)
    {
        services.Configure<FileShareConfiguration>(options =>
        {
            options.ConnectionString = connectionString;
            options.ShareName = shareName;
        });
        services.AddTransient<IFileShareClient, FileShareClient>();
        return services;
    }
}