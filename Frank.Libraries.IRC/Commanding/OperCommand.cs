namespace Frank.Libraries.IRC.Commanding
{
    public class OperCommand : ICommand
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public OperCommand()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}