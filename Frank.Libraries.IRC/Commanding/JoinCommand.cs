namespace Frank.Libraries.IRC.Commanding
{
    public class JoinCommand : ICommand
    {
        public string Channel { get; set; }
        public string Key { get; set; }

        public JoinCommand()
        {
            Channel = string.Empty;
            Key = string.Empty;
        }
    }
}