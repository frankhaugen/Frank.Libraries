namespace Frank.Libraries.IRC.Commanding
{
    public class InviteCommand : ICommand
    {
        public string Channel { get; set; }
        public string Nick { get; set; }

        public InviteCommand()
        {
            Channel = string.Empty;
            Nick = string.Empty;
        }
    }
}