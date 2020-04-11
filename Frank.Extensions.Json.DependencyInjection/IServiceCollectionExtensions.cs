using Microsoft.Extensions.DependencyInjection;

namespace Frank.Extensions.Json.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add this to register dependencies for this  library
        /// </summary>
        public static void AddJsonRepository<T>(this IServiceCollection services) where T : class, new()
        {
            services.AddSingleton<IJsonContext<T>, JsonContext<T>>();
            services.AddSingleton<IJsonRepository<T>, JsonRepository<T>>();
        }
    }
}
