namespace Frank.Libraries.IRC.Server.Persistance;

public class Message
{
    public int Id { get; set; }
    public int ChannelId { get; set; }
    public int UserId { get; set; }
    public string Text { get; set; }
    public DateTime Timestamp { get; set; }
}