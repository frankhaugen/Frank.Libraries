using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Extensions.Json
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add this to register dependencies for this  library
        /// </summary>
        public static void AddJsonRepository<TEntity, TConfig>(this IServiceCollection services, IConfiguration configuration) where TEntity : class, new() where TConfig : JsonContextConfigurationBase, new()
        {
            services.Configure<TConfig>(configuration.GetSection(typeof(TConfig).Name));
            services.AddSingleton<IJsonContext<TConfig>, JsonContext<TConfig>>();
            services.AddSingleton<IJsonRepository<TEntity, TConfig>, JsonRepository<TEntity, TConfig>>();
        }
    }
}
