using Frank.Libraries.IRC.Common;

namespace Frank.Libraries.IRC.Server;

public interface IIrcCommandHandler
{
    public IrcCommandName CommandName { get; }
    public Task<IrcMessage?> HandleAsync(IrcMessage message);
}