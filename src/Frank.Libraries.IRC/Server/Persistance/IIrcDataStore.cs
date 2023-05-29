namespace Frank.Libraries.IRC.Server.Persistance;

public interface IIrcDataStore
{
    void EnsureCreated(string connectionString);

    // Add a new user to the server
    void AddUser(User user);

    // Remove a user from the server
    void RemoveUser(string nickname);

    // Get a user by their nickname
    User GetUser(string nickname);

    // Get a list of all users on the server
    IEnumerable<User> GetAllUsers();

    // Add a new channel to the server
    void AddChannel(Channel channel);

    // Remove a channel from the server
    void RemoveChannel(string name);

    // Get a channel by its name
    Channel GetChannel(string name);

    // Get a list of all channels on the server
    IEnumerable<Channel> GetAllChannels();

    // Add a message to a channel
    void AddMessage(Channel channel, Message message);

    // Get a list of messages for a channel
    IEnumerable<Message> GetChannelMessages(Channel channel);

    // Add a message to a user
    void AddMessage(User user, Message message);

    // Get a list of messages for a user
    IEnumerable<Message> GetUserMessages(User user);
}