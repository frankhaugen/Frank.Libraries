using Frank.Libraries.DataStorage.Abstractions;

namespace Frank.Libraries.DataStorage.Json;

public interface IJsonDataStoreBuilder
{
    IJsonDataStoreBuilder AddRepository<T>() where T : class, IEntity;
}