using Frank.Libraries.DataStorage.Abstractions;

namespace Frank.Libraries.IRC.Server.Persistance.Models;

public class IrcChannel : IEntity
{
    public Guid Id { get; set; }
}

public class IrcUser : IEntity
{
    public Guid Id { get; set; }
}

public class IrcUserChannel : IEntity
{
    public Guid Id { get; set; }
}
