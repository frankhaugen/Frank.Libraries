namespace Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;

public static class NumericExtensions
{
    public static int ToInt(this float value) => (int)value;
    public static int ToInt(this double value) => (int)value;
    public static int ToInt(this decimal value) => (int)value;
    public static int ToInt(this long value) => (int)value;
    public static int ToInt(this uint value) => (int)value;
    public static int ToInt(this ulong value) => (int)value;
}