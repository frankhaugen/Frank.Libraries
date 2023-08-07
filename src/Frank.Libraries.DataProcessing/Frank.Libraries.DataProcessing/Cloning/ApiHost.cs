using Microsoft.Extensions.Hosting;

namespace Frank.Libraries.DataProcessing.Cloning;

public class ApiHost : IHost
{
    public void Dispose() => throw new NotImplementedException();

    public async Task StartAsync(CancellationToken cancellationToken = new CancellationToken()) => throw new NotImplementedException();

    public async Task StopAsync(CancellationToken cancellationToken = new CancellationToken()) => throw new NotImplementedException();

    public IServiceProvider Services { get; }
}