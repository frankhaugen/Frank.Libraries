using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Extensions.MongoDb
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add this to register dependencies for this  library
        /// </summary>
        public static void AddMongoDbRepository<TEntity, TConfig>(this IServiceCollection services, IConfiguration configuration) where TEntity : IMongoEntity, new() where TConfig : MongoDbConfigurationBase, new()
        {
            services.Configure<TConfig>(configuration.GetSection(typeof(TConfig).Name));
            services.AddSingleton<IMongoDbRepository<TEntity, TConfig>, MongoDbRepository<TEntity, TConfig>>();
            services.AddSingleton<IMongoDbContext<TConfig>, MongoDbContext<TConfig>>();
        }
    }
}
