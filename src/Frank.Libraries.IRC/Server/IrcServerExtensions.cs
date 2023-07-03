using Bedrock.Framework;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Frank.Libraries.IRC.Server;

public static class IrcServerExtensions
{
    public static void AddIrcServer(this HostApplicationBuilder applicationBuilder, int port = 6667)
    {
        applicationBuilder.AddServer(serverBuilder =>
        {
            serverBuilder.UseSockets(config => config.ListenAnyIP(port, connection => connection.UseConnectionLogging().UseConnectionHandler<IrcConnectionHandler>()));
        });
    }

    private static void AddServer(this HostApplicationBuilder applicationBuilder, Action<ServerBuilder> configure)
    {
        applicationBuilder.Services.AddHostedService<ServerHostedService>();
        applicationBuilder.Services.AddOptions<ServerHostedServiceOptions>()
                          .Configure<IServiceProvider>((options, sp) =>
                          {
                              options.ServerBuilder = new ServerBuilder(sp);
                              configure(options.ServerBuilder);
                          });
    }
}