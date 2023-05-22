using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.ValidateSslCertificate" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcValidateSslCertificateEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcValidateSslCertificateEventArgs" /> class.
    /// </summary>
    /// <param name="certificate">The certificate used to authenticate the remote party.</param>
    /// <param name="chain">The chain of certificate authorities.</param>
    /// <param name="sslPolicyErrors">The errors associated with the remote certificate.</param>
    public IrcValidateSslCertificateEventArgs(X509Certificate certificate, X509Chain chain,
                                              SslPolicyErrors sslPolicyErrors)
    {
        Certificate = certificate;
        Chain = chain;
        SslPolicyErrors = sslPolicyErrors;
    }

    /// <summary>
    ///     Gets the certificate used to authenticate the remote party..
    /// </summary>
    /// <value>The certificate.</value>
    public X509Certificate Certificate { get; }

    /// <summary>
    ///     Gets the chain of certificate authorities associated with the remote certificate.
    /// </summary>
    /// <value>The chain.</value>
    public X509Chain Chain { get; }

    /// <summary>
    ///     Gets the errors associated with the remote certificate.
    /// </summary>
    /// <value>The SSL policy errors.</value>
    public SslPolicyErrors SslPolicyErrors { get; }

    /// <summary>
    ///     Gets or sets whether the certificate given by the server is valid.
    /// </summary>
    /// <value><see langword="true" /> if the certificate is valid; <see langword="false" />, otherwise.</value>
    public bool IsValid { get; set; }
}