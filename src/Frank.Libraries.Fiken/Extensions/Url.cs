namespace Frank.Libraries.Fiken.Extensions;

public class Url
{
    public Url(string domain, string tld, bool userWww = true, bool isHttps = true)
    {
        Prefix = "http";
        Domain = domain;
        Tld = tld;
        Segments = new Dictionary<int, string>();
        SubDomains = new List<string>();

        if (isHttps)
        {
            Prefix += "s";
        }

        if (userWww)
        {
            SubDomains.Add("www");
        }
    }

    public string Prefix { get; }
    public string Tld { get; }
    public string Domain { get; }
    public Dictionary<int, string> Segments { get; }
    public List<string> SubDomains { get; }
}