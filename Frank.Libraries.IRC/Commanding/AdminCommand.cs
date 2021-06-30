namespace Frank.Libraries.IRC.Commanding
{
    public class AdminCommand : ICommand
    {
        public string Host { get; set; }

        public AdminCommand()
        {
            Host = string.Empty;
        }
    }
}