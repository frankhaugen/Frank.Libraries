namespace Frank.Libraries.IRC.Commanding
{
    public class RawCommand : ICommand
    {
        public string Message { get; set; }

        public RawCommand()
        {
            Message = string.Empty;
        }
    }
}