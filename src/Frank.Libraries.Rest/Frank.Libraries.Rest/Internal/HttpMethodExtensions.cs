namespace Frank.Libraries.Rest.Internal;

public static class HttpMethodExtensions
{
    public static HttpMethod ToHttpMethod(this Method source)
    {
        switch (source)
        {
            case Method.Get:
                return HttpMethod.Get;
            case Method.Post:
                return HttpMethod.Post;
            case Method.Put:
                return HttpMethod.Put;
            case Method.Delete:
                return HttpMethod.Delete;
            case Method.Patch:
                return HttpMethod.Patch;
            default:
                throw new Exception();
        }
    }
}