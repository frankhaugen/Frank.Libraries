namespace Frank.Libraries.IRC.Messaging
{
    public class KickInfo : IMessage
    {
        public string Channel { get; set; }
        public Nick Nick { get; set; }
        public Nick KickedNick { get; set; }
        public string Reason { get; set; }
    }
}