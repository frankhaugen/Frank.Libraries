using Frank.Libraries.Time.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Time.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    ///     Adds a <see cref="ITimeProvider" /> to the <see cref="IServiceCollection" />. The <see cref="ITimeProvider" /> will
    ///     return the current time.
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <returns></returns>
    public static IServiceCollection AddTimeProvider(this IServiceCollection serviceCollection) => serviceCollection.AddSingleton<ITimeProvider, DefaultTimeProvider>();

    /// <summary>
    ///     Adds a <see cref="ITimeProvider" /> to the <see cref="IServiceCollection" />. The <see cref="ITimeProvider" /> will
    ///     return the current time.
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <param name="fixedTime">The time that will be returned by the <see cref="ITimeProvider" /></param>
    /// <returns></returns>
    public static IServiceCollection AddTimeProvider(this IServiceCollection serviceCollection, DateTime fixedTime) => serviceCollection.AddSingleton<ITimeProvider>(new FixedTimeProvider(fixedTime));

    /// <summary>
    ///     Adds a <see cref="ITimeProvider" /> to the <see cref="IServiceCollection" />. The <see cref="ITimeProvider" /> will
    ///     return the current time.
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <typeparam name="T"> A class that implements <see cref="ITimeProvider" />. </typeparam>
    /// <returns></returns>
    public static IServiceCollection AddTimeProvider<T>(this IServiceCollection serviceCollection) where T : class, ITimeProvider => serviceCollection.AddSingleton<ITimeProvider, T>();

    /// <summary>
    ///     Adds a <see cref="ITimeProvider" /> to the <see cref="IServiceCollection" />. The <see cref="ITimeProvider" /> will
    ///     return the current time.
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <param name="provider">A class that implements <see cref="ITimeProvider" /></param>
    /// <typeparam name="T"> A class that implements <see cref="ITimeProvider" />. </typeparam>
    /// <returns></returns>
    public static IServiceCollection AddTimeProvider<T>(this IServiceCollection serviceCollection, T provider) where T : class, ITimeProvider => serviceCollection.AddSingleton<ITimeProvider>(provider);
}