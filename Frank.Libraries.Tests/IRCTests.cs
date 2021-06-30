using System.Linq;
using System.Net;
using FluentAssertions;
using Frank.Libraries.IRC;
using Xunit;
using Xunit.Abstractions;

namespace Frank.Libraries.Tests
{
    public class IRCTests : TestBase
    {
        private readonly IRC.IRC _irc;

        public IRCTests(ITestOutputHelper outputHelper) : base(outputHelper) => _irc = new IRC.IRC(1024);

        [Fact]
        public void Connect_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var ipAddress = IPAddress.Parse("127.0.0.1");
            var port = 6666;

            //var ipAddress = Dns.GetHostAddresses("irc.underworld.no").FirstOrDefault();
            Output(ipAddress?.ToString() ?? "null");

            // Act
            var result = _irc.Connect(ipAddress, port);

            //_irc.Login("webchat", new Nick() { Nickname = "testmike" });

            var channels = _irc.Channels.ToArray();
            Output(channels.FirstOrDefault());
            //_irc.Message.ChannelMessageReceivedEvent += (sender, message) => Output(message.Message);

            //_irc.Command.SendAway("testassage");

            // Assert

            result.Should().BeTrue();
        }

        [Fact]
        public void Disconnect_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            IPAddress IP = IPAddress.Parse("127.0.0.1");
            var port = 6666;
            _irc.Connect(IP, port);

            // Act
            _irc.Disconnect();

            // Assert
        }

        [Fact]
        public void Login_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            //var iRC = new IRC.IRC();
            string serverName = null;
            Nick nick = new Nick()
            {
                Host = "127.0.0.1"
            };

            // Act
            _irc.Login(serverName, nick);

            // Assert
        }

        //[Fact]
        //public void ParseChannelModeString_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    //var iRC = new IRC.IRC();
        //    string modeString = null;
        //    string parameterString = null;

        // // Act var result = iRC.ParseChannelModeString( modeString, parameterString);

        //    // Assert
        //    Assert.True(false);
        //}

        //[Fact]
        //public void ParseUserModeString_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    //var iRC = new IRC.IRC();
        //    string modeString = null;

        // // Act var result = iRC.ParseUserModeString( modeString);

        //    // Assert
        //    Assert.True(false);
        //}
    }
}