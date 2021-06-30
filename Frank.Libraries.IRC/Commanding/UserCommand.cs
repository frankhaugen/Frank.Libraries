namespace Frank.Libraries.IRC.Commanding
{
    public class UserCommand : ICommand
    {
        public string Username { get; set; }
        public string Hostname { get; set; }
        public string Servername { get; set; }
        public string Realname { get; set; }

        public UserCommand()
        {
            Username = string.Empty;
            Hostname = string.Empty;
            Hostname = string.Empty;
            Realname = string.Empty;
        }
    }
}