using LiteDB;

namespace Frank.Libraries.IRC.Server.Persistance;

public class LiteDbIrcDataStore : IIrcDataStore
{
    private LiteDatabase? _database;

    public void EnsureCreated(string connectionString = "Filename=IrcDataStore.db;Connection=shared")
    {
        _database = new LiteDatabase(connectionString);
    }

    public void AddUser(User user)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var users = _database.GetCollection<User>("users");
    }

    public void RemoveUser(string nickname)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var users = _database.GetCollection<User>("users");
    }

    public User GetUser(string nickname)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var users = _database.GetCollection<User>("users");
        return users.FindOne(x => x.Nickname == nickname);
    }

    public IEnumerable<User> GetAllUsers()
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var users = _database.GetCollection<User>("users");
        return users.FindAll();
    }

    public void AddChannel(Channel channel)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var channels = _database.GetCollection<Channel>("channels");
    }

    public void RemoveChannel(string name)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var channels = _database.GetCollection<Channel>("channels");
    }

    public Channel GetChannel(string name)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var channels = _database.GetCollection<Channel>("channels");
        return channels.FindOne(x => x.Name == name);
    }

    public IEnumerable<Channel> GetAllChannels()
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var channels = _database.GetCollection<Channel>("channels");
        return channels.FindAll();
    }

    public void AddMessage(Channel channel, Message message)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var messages = _database.GetCollection<Message>("messages");
    }

    public IEnumerable<Message> GetChannelMessages(Channel channel)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var messages = _database.GetCollection<Message>("messages");
        return messages.FindAll();
    }

    public void AddMessage(User user, Message message)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var messages = _database.GetCollection<Message>("messages");
    }

    public IEnumerable<Message> GetUserMessages(User user)
    {
        if (_database is null) throw new NullReferenceException("Database is null");
        var messages = _database.GetCollection<Message>("messages");
        return messages.FindAll().Where(x => x.UserId == user.Id);
    }
}