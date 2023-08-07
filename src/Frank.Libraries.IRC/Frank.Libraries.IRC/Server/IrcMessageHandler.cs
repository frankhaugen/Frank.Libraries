using Frank.Libraries.IRC.Common;

namespace Frank.Libraries.IRC.Server;

public class IrcMessageHandler
{
    private readonly IEnumerable<IIrcCommandHandler> _commandHandlers;

    /// <summary>
    /// Handles the message and returns a response if applicable
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public async Task<IrcMessage?> HandleAsync(IrcMessage message)
    {
        var commandName = IrcCommandIdentifier.IdentifyCommand(message);

        var commandHandler = _commandHandlers.FirstOrDefault(x => x.CommandName == commandName);
        if (commandHandler != null)
            return await commandHandler.HandleAsync(message);
        return new IrcMessage(":servername 421 nickname command :Unknown This command was not recognized by the server");
    }
}