namespace Frank.Libraries.IRC.Commanding
{
    public class InfoCommand : ICommand
    {
        public string Host { get; set; }

        public InfoCommand()
        {
            Host = string.Empty;
        }
    }
}