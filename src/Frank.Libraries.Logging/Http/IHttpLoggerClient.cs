using Frank.Libraries.Logging.Shared;

namespace Frank.Libraries.Logging.Http;

public interface IHttpLoggerClient
{
    void SendLog(Uri endpoint, Log log);
}