namespace Frank.Libraries.IRC.Common;

public class IrcMessage
{
    public IrcMessagePrefix? Prefix { get; }
    public string? Command { get; }
    public string? Channel { get; set; }
    public string? Message { get; set; }

    public IrcMessage(string message)
    {
        var parts = message.Split(' ');

        if (parts[0].StartsWith(":"))
        {
            Prefix = new IrcMessagePrefix(parts[0].Substring(1));
            Command = parts[1];
        }
        else
        {
            Command = parts[0];
        }

        for (int i = Prefix != null ? 2 : 1; i < parts.Length; i++)
        {
            var part = parts[i];
            if (part.StartsWith("#"))
            {
                Channel = part;
            }
            else if (part.StartsWith(":"))
            {
                Message = message.Substring(message.IndexOf(part) + 1);
                break;
            }
            else if (i == parts.Length - 1)
            {
                Message = part;
            }
        }
    }

    public override string ToString()
    {
        var parts = new List<string>();
        if (Prefix != null)
        {
            parts.Add($":{Prefix}");
        }

        if (Command != null)
        {
            parts.Add(Command);
        }

        if (Channel != null)
        {
            parts.Add(Channel);
        }

        if (Message != null)
        {
            parts.Add($":{Message}");
        }

        return string.Join(" ", parts);
    }
}
