namespace Frank.Libraries.DataProcessing.Cloning;

public static class HeaderFactory
{
    public static Header Custom(string key, string value) => new(key, value);
    public static Header Autorization(string value) => new(KnownHeaderNames.Authorization, value);
    public static Header Accept(string value) => new(KnownHeaderNames.Accept, value);
    public static Header Allow(string value) => new(KnownHeaderNames.Allow, value);
    public static Header Expires(string value) => new(KnownHeaderNames.Expires, value);
    public static Header ContentDisposition(string value) => new(KnownHeaderNames.ContentDisposition, value);
    public static Header ContentEncoding(string value) => new(KnownHeaderNames.ContentEncoding, value);
    public static Header ContentLanguage(string value) => new(KnownHeaderNames.ContentLanguage, value);
    public static Header ContentLength(string value) => new(KnownHeaderNames.ContentLength, value);
    public static Header ContentLocation(string value) => new(KnownHeaderNames.ContentLocation, value);
    public static Header ContentRange(string value) => new(KnownHeaderNames.ContentRange, value);
    public static Header ContentType(string value) => new(KnownHeaderNames.ContentType, value);
    public static Header Cookie(string value) => new(KnownHeaderNames.Cookie, value);
    public static Header LastModified(string value) => new(KnownHeaderNames.LastModified, value);
    public static Header ContentMD5(string value) => new(KnownHeaderNames.ContentMD5, value);
    public static Header Host(string value) => new(KnownHeaderNames.Host, value);
}