using Frank.Libraries.DataStorage.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.DataStorage.Json;

public class JsonDataStoreBuilder : IJsonDataStoreBuilder
{
    private readonly IServiceCollection _services;

    public JsonDataStoreBuilder(IServiceCollection services) => _services = services;

    public IJsonDataStoreBuilder AddRepository<T>() where T : class, IEntity
    {
        _services.AddSingleton<IJsonDirectory<T>, JsonDirectory<T>>();
        _services.AddSingleton<IRepository<T>, JsonRepository<T>>();
        return this;
    }
}