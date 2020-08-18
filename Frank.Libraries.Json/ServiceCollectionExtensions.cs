using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Json
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add this to register dependencies for this  library
        /// </summary>
        public static void AddJsonRepository<TEntity, TConfig>(this IServiceCollection services, IConfiguration configuration) where TEntity : class, new() where TConfig : JsonContextConfigurationBase, new()
        {
            services.Configure<TConfig>(configuration.GetSection(typeof(TConfig).Name));
            services.AddSingleton<IJsonContext, JsonContext<TConfig>>();
            services.AddSingleton<IJsonRepository<TEntity>, JsonRepository<TEntity>>();
        }
    }
}