namespace Frank.Libraries.IRC.Messaging
{
    public class TopicChangeInfo : IMessage
    {
        public string Channel { get; set; }
        public Nick Nick { get; set; }
        public string Topic { get; set; }
    }
}