namespace Frank.Libraries.IRC.Commanding
{
    public class PartCommand : ICommand
    {
        public string Channel { get; set; }

        public PartCommand()
        {
            Channel = string.Empty;
        }
    }
}