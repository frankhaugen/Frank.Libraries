using System.Xml.Schema;

namespace Frank.Libraries.Ubl.Validation;

public class XsdException : Exception
{
    public XsdException(string s, Exception? innerException = null) : base(s, innerException)
    {
    }

    public XsdException(object? sender, ValidationEventArgs e) : base(e.Message, e.Exception)
    {
    }
}