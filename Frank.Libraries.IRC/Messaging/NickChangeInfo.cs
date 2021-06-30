namespace Frank.Libraries.IRC.Messaging
{
    public class NickChangeInfo : IMessage
    {
        public Nick OldNick { get; set; }
        public Nick NewNick { get; set; }
    }
}