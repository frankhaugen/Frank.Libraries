using System.Text;
using Frank.Libraries.IRC.Common;

namespace Frank.Libraries.Tests.Irc.Common;

public class RawMessageTests
{
    [Theory]
    [InlineData(":nick!user@host PRIVMSG #channel :Hello, world!", "nick!user@host", "PRIVMSG", new[] { "#channel", ":Hello, world!" })]
    [InlineData("PING :123456", null, "PING", new[] { ":123456" })]
    [InlineData("JOIN #channel", null, "JOIN", new[] { "#channel" })]
    public void RawMessage_ParsesMessageCorrectly(string message, string prefix, string command, string[] parameters)
    {
        var rawMessage = new RawMessage(Encoding.UTF8.GetBytes(message));

        Assert.Equal(prefix, rawMessage.Prefix);
        Assert.Equal(command, rawMessage.Command);
        Assert.Equal(parameters, rawMessage.Parameters);
    }

    [Theory]
    [InlineData(":nick!user@host PRIVMSG #channel :Hello, world!", ":nick!user@host PRIVMSG #channel :Hello, world!")]
    [InlineData("PING :123456", "PING :123456")]
    [InlineData("JOIN #channel", "JOIN #channel")]
    public void RawMessage_ToString_ReturnsCorrectString(string message, string expected)
    {
        var rawMessage = new RawMessage(Encoding.UTF8.GetBytes(message));
        var actual = rawMessage.ToString();

        Assert.Equal(expected, actual);
    }
}