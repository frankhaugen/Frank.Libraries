namespace Frank.Libraries.IRC.Commanding
{
    public class UserModeCommand : ICommand
    {
        public string Nick { get; set; }
        public UserModeInfo Mode { get; set; }

        public UserModeCommand()
        {
            Nick = string.Empty;
            Mode = new UserModeInfo();
        }
    }
}