using Bedrock.Framework.Protocols;
using Frank.Libraries.IRC.Common;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.IRC.Server;

public class IrcConnectionHandler : ConnectionHandler
{
    private readonly ILogger<IrcConnectionHandler> _logger;

    public IrcConnectionHandler(ILogger<IrcConnectionHandler> logger)
    {
        _logger = logger;
    }

    public override async Task OnConnectedAsync(ConnectionContext connection)
    {
        var protocol = new IrcProtocol();
        var reader = connection.CreateReader();
        var writer = connection.CreateWriter();

        while (true)
        {
            try
            {
                var result = await reader.ReadAsync(protocol);
                var message = result.Message;

                if (result.IsCompleted)
                {
                    break;
                }

                if (message.Command.Equals("ping", StringComparison.OrdinalIgnoreCase))
                {
                    await writer.WriteAsync(protocol, new IrcMessage("PONG"));
                }


                if (result.IsCompleted)
                {
                    break;
                }
            }
            finally
            {
                reader.Advance();
            }
        }
    }
}