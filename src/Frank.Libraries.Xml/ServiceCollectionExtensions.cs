using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Xml
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add this to register dependencies for the XML Context
        /// </summary>
        public static void AddXml<TEntity>(this IServiceCollection services, IConfiguration configuration) where TEntity : XmlEntity, new()
        {
            services.Configure<XmlConfiguration>(configuration.GetSection(nameof(XmlConfiguration)));
            services.AddSingleton<IXmlContext<TEntity>, XmlContext<TEntity>>();
        }
    }
}