using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Json
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add this to register dependencies for this  library
        /// </summary>
        public static void AddJsonRepository<TEntity>(this IServiceCollection services, IConfiguration configuration) where TEntity : JsonEntity, new()
        {
            services.Configure<JsonConfiguration>(configuration.GetSection(nameof(JsonConfiguration)));
            services.AddSingleton<IJsonContext<TEntity>, JsonContext<TEntity>>();
            services.AddSingleton<IJsonRepository<TEntity>, JsonRepository<TEntity>>();
        }
    }
}
