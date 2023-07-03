namespace Frank.Libraries.IRC.Common;

public class IrcMessagePrefix
{
    public string? Nick { get; set; }
    public string? User { get; set; }
    public string? Host { get; set; }

    public IrcMessagePrefix(string prefix)
    {
        if (prefix.StartsWith(":"))
        {
            prefix = prefix.Substring(1);
        }

        var parts = prefix.Split('@');
        if (parts.Length == 2)
        {
            Host = parts[1];
            var nickUser = parts[0].Split('!');
            if (nickUser.Length == 2)
            {
                Nick = nickUser[0];
                User = nickUser[1];
            }
            else
            {
                Nick = parts[0];
            }
        }
        else
        {
            Nick = prefix;
        }
    }

    public override string ToString()
    {
        if (Nick != null)
        {
            if (User != null && Host != null)
            {
                return $"{Nick}!{User}@{Host}";
            }
            else
            {
                return $"{Nick}";
            }
        }
        else
        {
            return "";
        }
    }
}