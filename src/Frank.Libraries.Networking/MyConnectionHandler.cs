using System.Buffers;
using Microsoft.AspNetCore.Connections;

namespace Frank.Libraries.Networking;

public class MyConnectionHandler : ConnectionHandler
{
    public override async Task OnConnectedAsync(ConnectionContext connection)
    {
        while (true)
        {
            var result = await connection.Transport.Input.ReadAsync();
            var buffer = result.Buffer;

            try
            {
                if (buffer.IsEmpty && result.IsCompleted)
                    break;

                // Handle the received data
                ProcessReceivedData(buffer);

                // Advance the buffer to indicate we've consumed the data
                connection.Transport.Input.AdvanceTo(buffer.End);
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                // You can log or handle errors according to your requirements
                break;
            }
        }
    }

    private void ProcessReceivedData(ReadOnlySequence<byte> buffer)
    {
        foreach (var segment in buffer)
        {
            // Deserialize the received data
            var message = SerializationHelper.Deserialize<Message>(segment.Span);

            // Perform server-side operations based on the data
            Console.WriteLine($"Received message from {message.Sender}: {message.Content}");
        }
    }
}