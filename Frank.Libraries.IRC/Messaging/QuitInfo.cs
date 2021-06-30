namespace Frank.Libraries.IRC.Messaging
{
    public class QuitInfo : IMessage
    {
        public Nick Nick { get; set; }
        public string Message { get; set; }
    }
}