using System.ComponentModel;
using System.Net.Sockets;
using Frank.Libraries.IRC.Common;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.IRC.Server;

public class IrcServer : BackgroundService
{
    private readonly ILogger<IrcServer> _logger;
    private readonly IIrcMessageHandler _ircMessageHandler;

    public IrcServer(ILogger<IrcServer> logger, IIrcMessageHandler ircMessageHandler)
    {
        _logger = logger;
        _ircMessageHandler = ircMessageHandler;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);



            await Task.Delay(1000, stoppingToken);
        }
    }
}

public interface IIrcMessageHandler
{
    Task HandleAsync(RawMessage message);
}

internal class IrcMessage
{
    public IrcMessage(IrcMessageRaw messageRaw)
    {
        throw new NotImplementedException();
    }

    public string GetCommand()
    {
        throw new NotImplementedException();
    }
}

internal readonly record struct IrcMessageRaw(string Raw);

public class IrcSocketOptions
{
    public string Host { get; set; } = "irc.chat.twitch.tv";
    public int Port { get; set; } = 6667;
    public string Nickname { get; set; } = "justinfan12345";
    public string Password { get; set; } = "SCHMOOPIIE";
    public string Channel { get; set; } = "#schmoopiie";
}

internal class IrcSocket : Socket
{
    public IrcSocket(string host, int port) : base(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    {
        Connect(host, port);
    }
}