using System.ComponentModel;

namespace Frank.Libraries.IRC
{
    public enum ServerStat
    {
        [Description("List of Servers that allow Server Connection")]
        c,
        [Description("List of Server Hubs")]
        h,
        [Description("List of Hosts that allow Client Connection")]
        i,
        [Description("List of banned user/hostname of Server")]
        k,
        [Description("Lists Server Connections")]
        l,
        [Description("Commands Supported")]
        m,
        [Description("Lists Hosts that allow Normal Operators")]
        o,
        [Description("List Class lines from Server Config")]
        y,
        [Description("Server Uptime")]
        u
    }
}