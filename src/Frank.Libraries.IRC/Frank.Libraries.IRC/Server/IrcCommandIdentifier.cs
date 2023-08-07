using Frank.Libraries.IRC.Common;

namespace Frank.Libraries.IRC.Server;

public static class IrcCommandIdentifier
{
    public static IrcCommandName IdentifyCommand(IrcMessage message)
    {
        if (message.Command != null && Enum.TryParse<IrcCommandName>(message.Command, out var commandName))
            return commandName;
        return IrcCommandName.Unknown;
    }
}