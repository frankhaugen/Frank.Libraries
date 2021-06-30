namespace Frank.Libraries.IRC.Messaging
{
    public class JoinChannelInfo : IMessage
    {
        public string Channel { get; set; }
        public Nick Nick { get; set; }
    }
}