using System.Buffers;
using System.Text;
using Bedrock.Framework.Protocols;

namespace Frank.Libraries.IRC.Common;

public class IrcProtocol : IMessageReader<IrcMessage>, IMessageWriter<IrcMessage>
{
    public bool TryParseMessage(in ReadOnlySequence<byte> input, ref SequencePosition consumed, ref SequencePosition examined, out IrcMessage message)
    {
        ReadOnlySpan<byte> buffer = input.FirstSpan;
        var rawMessage = Encoding.UTF8.GetString(buffer.ToArray());
        message = new IrcMessage(rawMessage);
        consumed = input.End;
        return true;
    }

    public void WriteMessage(IrcMessage message, IBufferWriter<byte> output)
    {
        Encoding.UTF8.GetBytes(message.ToString(), output);
    }
}