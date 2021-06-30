namespace Frank.Libraries.IRC.Commanding
{
    public class AwayCommand : ICommand
    {
        public string Message { get; set; }

        public AwayCommand()
        {
            Message = string.Empty;
        }
    }
}