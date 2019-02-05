namespace Simplic.Exchange
{
    /// <summary>
    /// Exchange credential encryption
    /// </summary>
    public interface IExchangeCredentialEncryption
    {
        /// <summary>
        /// Encrypt passwort
        /// </summary>
        /// <param name="password">Exchange password</param>
        /// <returns>Password hash</returns>
        byte[] Encrypt(string password);

        /// <summary>
        /// Decrypt the exchange password
        /// </summary>
        /// <param name="password">User password</param>
        /// <returns>Exchange password hash</returns>
        string Decrypt(byte[] password);
    }
}
