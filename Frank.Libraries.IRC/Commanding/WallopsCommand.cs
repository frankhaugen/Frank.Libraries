namespace Frank.Libraries.IRC.Commanding
{
    public class WallopsCommand : ICommand
    {
        public string Message { get; set; }

        public WallopsCommand()
        {
            Message = string.Empty;
        }
    }
}