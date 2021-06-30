namespace Frank.Libraries.IRC.Commanding
{
    public class UsersCommand : ICommand
    {
        public string Server { get; set; }

        public UsersCommand()
        {
            Server = string.Empty;
        }
    }
}