using System.Collections;

namespace Frank.Libraries.DataProcessing.Cloning;

public static class HttpSchemeExtensions
{
    public static string ToSchemeStringWithTrail(this HttpScheme httpScheme) => httpScheme.ToSchemeString() + "://";

    public static string ToSchemeString(this HttpScheme httpScheme)
    {
        return httpScheme switch
        {
            HttpScheme.Http => "http",
            HttpScheme.Https => "https",
            _ => throw new ArgumentOutOfRangeException(nameof(httpScheme), httpScheme, null)
        };
    }
}

public enum HttpScheme
{
    Http,
    Https
}





public static class DefaultPortExtensions
{
    public static Port ToDefaultPort(this HttpScheme httpScheme)
    {
        return httpScheme switch
        {
            HttpScheme.Http  => new PortList().Single(x => x.Value == 80),
            HttpScheme.Https => new PortList().Single(x => x.Value == 443),
            _                => throw new ArgumentOutOfRangeException(nameof(httpScheme), httpScheme, null)
        };
    }
}

public class PortList : IEnumerable<Port>
{
    private readonly List<Port> _ports = new() {

        new Port { Value = 1, Name = "tcpmux" },
        new Port { Value = 2, Name = "compressnet" },
        new Port { Value = 3, Name = "compressnet" },
        new Port { Value = 5, Name = "rje" },
        new Port { Value = 7, Name = "echo" },
        new Port { Value = 9, Name = "discard" },
        new Port { Value = 11, Name = "systat" },
        new Port { Value = 13, Name = "daytime" },
        new Port { Value = 17, Name = "qotd" },
        new Port { Value = 18, Name = "msp" },
        new Port { Value = 19, Name = "chargen" },
        new Port { Value = 20, Name = "ftp-data" },
        new Port { Value = 21, Name = "ftp" },
        new Port { Value = 22, Name = "ssh" },
        new Port { Value = 23, Name = "telnet" },
        new Port { Value = 25, Name = "smtp" },
        new Port { Value = 37, Name = "time" },
        new Port { Value = 42, Name = "nameserver" },
        new Port { Value = 43, Name = "nicname" },
        new Port { Value = 49, Name = "tacacs" },
        new Port { Value = 53, Name = "domain" },
        new Port { Value = 63, Name = "whois++" },
        new Port { Value = 67, Name = "bootps" },
        new Port { Value = 68, Name = "bootpc" },
        new Port { Value = 69, Name = "tftp" },
        new Port { Value = 70, Name = "gopher" },
        new Port { Value = 79, Name = "finger" },
        new Port { Value = 80, Name = "http", IsDefault = true },
        new Port { Value = 88, Name = "kerberos" },
        new Port { Value = 95, Name = "supdup" },
        new Port { Value = 101, Name = "hostname" },
        new Port { Value = 102, Name = "iso-tsap" },
        new Port { Value = 103, Name = "gppitnp" },
        new Port { Value = 104, Name = "acr-nema" },
        new Port { Value = 109, Name = "pop2" },
        new Port { Value = 110, Name = "pop3" },
        new Port { Value = 111, Name = "sunrpc" },
        new Port { Value = 113, Name = "auth" },
        new Port { Value = 115, Name = "sftp" },
        new Port { Value = 117, Name = "uucp-path" },
        new Port { Value = 119, Name = "nntp" },
        new Port { Value = 123, Name = "ntp" },
        new Port { Value = 135, Name = "epmap" },
        new Port { Value = 137, Name = "netbios-ns" },
        new Port { Value = 138, Name = "netbios-dgm" },
        new Port { Value = 139, Name = "netbios-ssn" },
        new Port { Value = 143, Name = "imap" },
        new Port { Value = 161, Name = "snmp" },
        new Port { Value = 162, Name = "snmptrap" },
        new Port { Value = 177, Name = "xdmcp" },
        new Port { Value = 179, Name = "bgp" },
        new Port { Value = 194, Name = "irc" },
        new Port { Value = 201, Name = "at-rtmp" },
        new Port { Value = 202, Name = "at-nbp" },
        new Port { Value = 204, Name = "at-echo" },
        new Port { Value = 206, Name = "at-zis" },
        new Port { Value = 443, Name = "https" },
        new Port { Value = 1025, Name = "network blackjack" },
        new Port { Value = 8080, Name = "http-alt" },
        new Port { Value = 8443, Name = "https-alt" },
        new Port { Value = 8888, Name = "http-alt" },
        new Port { Value = 8889, Name = "https-alt" },

    };

    public Port Get(ushort value) => _ports.Single(x => x.Value.Equals(value));

    public IEnumerator<Port> GetEnumerator() => _ports.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


public class Port
{
    public ushort Value { get; set; }
    public string? Name { get; set; }
    public bool IsDefault { get; set; }
}