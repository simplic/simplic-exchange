using System;

namespace Simplic.Exchange
{
    /// <summary>
    /// Credential repository
    /// </summary>
    public interface ICredentialRepository : Data.IRepositoryBase<long, ExchangeCredential>
    {
    }
}
