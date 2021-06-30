namespace Frank.Libraries.IRC.Commanding
{
    public class ListCommand : ICommand
    {
        public string Channel { get; set; }

        public ListCommand()
        {
            Channel = string.Empty;
        }
    }
}