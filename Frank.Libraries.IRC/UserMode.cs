using System.ComponentModel;

namespace Frank.Libraries.IRC
{
    public enum UserMode
    {
        [Description("Service Administrator")]
        a,
        [Description("Service Administrator")]
        A,
        [Description("Bot")]
        B,
        [Description("Connection Notice")]
        c,
        [Description("Co-Administrator")]
        C,
        [Description("Deaf")]
        d,
        [Description("View 'Eyes' Server Messages")]
        e,
        [Description("Flood Alerts")]
        f,
        [Description("Remote Server Connection Notice")]
        F,
        [Description("GlobOp and LocOp Messages")]
        g,
        [Description("Censored")]
        G,
        [Description("Helpful")]
        h,
        [Description("Hide IRCop Status")]
        H,
        [Description("Invisible")]
        i,
        [Description("Junk Messages")]
        j,
        [Description("Kill Messages")]
        k,
        [Description("Nick Change Notice")]
        n,
        [Description("Network Administrator")]
        N,
        [Description("Global Operator")]
        o,
        [Description("Local Operator")]
        O,
        [Description("Hide All Channels")]
        p,
        [Description("U:Lines Only")]
        q,
        [Description("Registered")]
        r,
        [Description("Registered Messages Only")]
        R,
        [Description("Server Notices")]
        s,
        [Description("Services Only")]
        S,
        [Description("VHost")]
        t,
        [Description("No CTCP")]
        T,
        [Description("Receive Bad DCC")]
        v,
        [Description("WebTV User")]
        V,
        [Description("Wallops")]
        w,
        [Description("Whois Notice")]
        W,
        [Description("Hidden Hostname")]
        x,
        [Description("Secure Connection")]
        z
    }
}