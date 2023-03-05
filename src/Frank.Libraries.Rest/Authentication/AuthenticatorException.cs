using System;

namespace Frank.Libraries.Rest.Authentication;

public class AuthenticatorException : Exception
{
    public AuthenticatorException(string message) : base(message)
    {
    }
}