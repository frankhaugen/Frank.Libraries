using Frank.Libraries.DataStorage;

namespace Frank.Libraries.IRC.Server.Persistance.Models;

public class IrcChannel : IKeyed
{
    public Guid Id { get; set; }
}

public class IrcUser : IKeyed
{
    public Guid Id { get; set; }
}

public class IrcUserChannel : IKeyed
{
    public Guid Id { get; set; }
}
