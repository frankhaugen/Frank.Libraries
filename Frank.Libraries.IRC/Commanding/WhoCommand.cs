namespace Frank.Libraries.IRC.Commanding
{
    public class WhoCommand : ICommand
    {
        public string Host { get; set; }

        public WhoCommand()
        {
            Host = string.Empty;
        }
    }
}