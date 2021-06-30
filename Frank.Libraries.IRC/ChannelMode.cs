using System.ComponentModel;

namespace Frank.Libraries.IRC
{
    public enum ChannelMode
    {
        [Description("Admin")]
        a,
        [Description("Admin Only")]
        A,
        [Description("Ban")]
        b,
        [Description("Colourless")]
        c,
        [Description("No CTCP")]
        C,
        [Description("Ban Exempt")]
        e,
        [Description("Flood Protection")]
        f,
        [Description("HalfOp")]
        h,
        [Description("Invite Only")]
        i,
        [Description("Invite Exempt")]
        I,
        [Description("Join Throttling")]
        j,
        [Description("Key")]
        k,
        [Description("No KNOCK")]
        K,
        [Description("Limit")]
        l,
        [Description("Link")]
        L,
        [Description("Moderated")]
        m,
        [Description("Registered Nicks May Talk")]
        M,
        [Description("No External Messages")]
        n,
        [Description("No Nickname Changes")]
        N,
        [Description("Operator")]
        o,
        [Description("Oper Only")]
        O,
        [Description("Private")]
        p,
        [Description("Founder")]
        q,
        [Description("No Kicks Allowed")]
        Q,
        [Description("Registered")]
        r,
        [Description("Registered Only")]
        R,
        [Description("Secret")]
        s,
        [Description("Strip Mirc Colors")]
        S,
        [Description("+hoaq Only Topic Change")]
        t,
        [Description("No Notices")]
        T,
        [Description("Auditorium")]
        u,
        [Description("Voice")]
        v,
        [Description("No Invite")]
        V,
        [Description("Secure Only")]
        z
    }
}