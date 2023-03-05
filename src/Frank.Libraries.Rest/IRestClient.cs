using System.Threading.Tasks;
using Frank.Libraries.Rest.Serialization;

namespace Frank.Libraries.Rest;

public interface IRestClient
{
    ISerializer Serializer { get; }
    Task<IResponse<T>> SendAsync<T>(IRequest request);
    Task<IResponse> SendAsync(IRequest request);
}