namespace Frank.Libraries.Fiken.Extensions;

public static class StringExtensions
{
    /// <summary>
    /// Encode string in base64 format.
    /// </summary>
    /// <param name="text">String to be encoded.</param>
    /// <returns>Encoded string.</returns>
    public static string Base64Encode(this string text)
    {
        var textByte = System.Text.Encoding.UTF8.GetBytes(text);
        return Convert.ToBase64String(textByte);
    }
}