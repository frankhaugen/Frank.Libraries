namespace Frank.Libraries.IRC.Commanding
{
    public class PasswordCommand : ICommand
    {
        public string Password { get; set; }

        public PasswordCommand()
        {
            Password = string.Empty;
        }
    }
}