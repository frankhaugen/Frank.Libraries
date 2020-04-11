using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Extensions.MongoDb
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add this to register dependencies for this  library
        /// </summary>
        public static void AddMongoDbContext<TConfig>(this IServiceCollection services, IConfiguration configuration) where TConfig : MongoDbConfigurationBase, new()
        {
            services.Configure<TConfig>(configuration.GetSection(nameof(TConfig)));
            services.AddSingleton(typeof(IMongoDbContext<TConfig>), typeof(MongoDbContext<TConfig>));
        }
    }
}
