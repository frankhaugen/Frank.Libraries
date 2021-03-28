using System.Linq;
using System.Net;
using FluentAssertions;
using Frank.Libraries.IRC;
using Xunit;

namespace Frank.Libraries.Tests
{
    public class IRCTests
    {
        private readonly IRC.IRC _irc;

        public IRCTests() => _irc = new IRC.IRC(1024);

        [Fact]
        public void Connect_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            IPAddress IP = IPAddress.Parse("127.0.0.1");
            int port = 6666;

            // Act
            var result = _irc.Connect(IP, port);

            _irc.Channels.FirstOrDefault();
            _irc.Command.SendAway("Kessage");

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Disconnect_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            IPAddress IP = IPAddress.Parse("127.0.0.1");
            int port = 6666;
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