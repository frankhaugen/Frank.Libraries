using System.IO.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Json
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add this to register dependencies for the Json Context
        /// </summary>
        public static void AddJson<TEntity>(this IServiceCollection services, IConfiguration configuration) where TEntity : JsonEntity, new()
        {
            services.Configure<JsonConfiguration>(configuration.GetSection(nameof(JsonConfiguration)));
            services.AddSingleton<IJsonContext<TEntity>, JsonContext<TEntity>>();
            services.AddTransient<IFileSystem, FileSystem>();
        }
    }
}
