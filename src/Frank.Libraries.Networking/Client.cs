using Microsoft.AspNetCore.Connections;

namespace Frank.Libraries.Networking;

public class Client
{
    public async Task ConnectAsync(IServiceProvider serviceProvider)
    {
        var connection = new ConnectionBuilder(serviceProvider)
                         .UseConnectionHandler<MyConnectionHandler>()
                         .Build();

        // Create a sample message
        var message = new Message
        {
            Sender = "Client1",
            Content = "Hello, server!"
        };

        // Serialize the message
        var data = SerializationHelper.Serialize(message);
    }
}