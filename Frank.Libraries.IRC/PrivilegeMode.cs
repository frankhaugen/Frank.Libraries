using System.ComponentModel;

namespace Frank.Libraries.IRC
{
    public enum PrivilegeMode
    {
        [Description("Voice")]
        v,
        [Description("Half-Operator")]
        h,
        [Description("Operator")]
        o,
        [Description("Super Operator")]
        a,
        [Description("Founder")]
        q
    }
}