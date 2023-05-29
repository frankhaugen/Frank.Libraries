namespace Frank.Libraries.IRC.Server.Persistance;

public class User
{
    public int Id { get; set; }
    public string Nickname { get; set; }
    public string RealName { get; set; }
    public string Hostname { get; set; }
    public string Servername { get; set; }
    public bool IsOperator { get; set; }
    public bool IsAway { get; set; }
    public string AwayMessage { get; set; }
    public DateTime LastActivity { get; set; }
}