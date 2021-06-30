namespace Frank.Libraries.IRC.Commanding
{
    public class TopicCommand : ICommand
    {
        public string Channel { get; set; }
        public string Topic { get; set; }

        public TopicCommand()
        {
            Channel = string.Empty;
            Topic = string.Empty;
        }
    }
}