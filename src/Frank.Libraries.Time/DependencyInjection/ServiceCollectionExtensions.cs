using Microsoft.Extensions.DependencyInjection;
using NodaTime;

namespace Frank.Libraries.Time.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFrankTime(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IClock, SystemClock>();
            serviceCollection.AddSingleton<TimeService>();

            return serviceCollection;
        }
    }
}
