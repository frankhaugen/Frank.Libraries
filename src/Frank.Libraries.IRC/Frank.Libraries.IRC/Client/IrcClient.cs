using System.Net;
using Bedrock.Framework;
using Bedrock.Framework.Protocols;
using Frank.Libraries.IRC.Common;

namespace Frank.Libraries.IRC.Client;

public class IrcClient
{
    private readonly IServiceProvider _serviceProvider;
    private Bedrock.Framework.Client? _client;

    public IrcClient(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

    public async Task<IrcMessage?> SendMessageAsync(IrcMessage message)
    {
        _client ??= new ClientBuilder(_serviceProvider)
                    .UseSockets()
                    .UseConnectionLogging()
                    .Build();

        var connection = await _client.ConnectAsync(new IPEndPoint(IPAddress.Loopback, 6667));

        var protocol = new IrcProtocol();
        var writer = connection.CreateWriter();
        var reader = connection.CreateReader();
        await writer.WriteAsync(protocol, message);

        var response = await reader.ReadAsync(protocol);

        return response.Message;
    }
}