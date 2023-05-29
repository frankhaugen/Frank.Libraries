using Microsoft.Data.Sqlite;

namespace Frank.Libraries.IRC.Server.Persistance;

public class SqliteIrcDataStore : IIrcDataStore
{
    private readonly SqliteConnection _connection;

    public void EnsureCreated(string connectionString)
    {
        _connection.ConnectionString = connectionString;
        _connection.Open();
    }

    public void AddUser(User user) => throw new NotImplementedException();

    public void RemoveUser(string nickname) => throw new NotImplementedException();

    public User GetUser(string nickname) => throw new NotImplementedException();

    public IEnumerable<User> GetAllUsers() => throw new NotImplementedException();

    public void AddChannel(Channel channel) => throw new NotImplementedException();

    public void RemoveChannel(string name) => throw new NotImplementedException();

    public Channel GetChannel(string name) => throw new NotImplementedException();

    public IEnumerable<Channel> GetAllChannels() => throw new NotImplementedException();

    public void AddMessage(Channel channel, Message message) => throw new NotImplementedException();

    public IEnumerable<Message> GetChannelMessages(Channel channel) => throw new NotImplementedException();

    public void AddMessage(User user, Message message) => throw new NotImplementedException();

    public IEnumerable<Message> GetUserMessages(User user) => throw new NotImplementedException();
}