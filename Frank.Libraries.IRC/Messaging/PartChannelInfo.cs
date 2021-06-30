namespace Frank.Libraries.IRC.Messaging
{
    public class PartChannelInfo : IMessage
    {
        public string Channel { get; set; }
        public Nick Nick { get; set; }
    }
}