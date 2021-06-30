namespace Frank.Libraries.IRC.Commanding
{
    public class KickCommand : ICommand
    {
        public string Channel { get; set; }
        public string Nick { get; set; }
        public string Reason { get; set; }

        public KickCommand()
        {
            Channel = string.Empty;
            Nick = string.Empty;
            Reason = string.Empty;
        }
    }
}