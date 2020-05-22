using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Extensions.MongoDb
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add this to register dependencies for this  library
        /// </summary>
        public static void AddMongoDbRepository<TEntity, TConfig>(this IServiceCollection services, IConfiguration configuration) where TEntity : MongoEntity, new() where TConfig : MongoDbConfigurationBase, new()
        {
            services.Configure<TConfig>(configuration.GetSection(typeof(TConfig).Name));
            services.AddSingleton<IMongoDbRepository<TEntity>, MongoDbRepository<TEntity>>();
            services.AddSingleton<IMongoDbContext, MongoDbContext<TConfig>>();
        }
    }
}