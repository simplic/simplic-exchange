using Microsoft.Exchange.WebServices.Data;
using Simplic.Security.Cryptography;
using System;
using System.Net;
using System.Text;

namespace Simplic.Exchange
{
    /// <summary>
    /// Exchange service builder
    /// </summary>
    public class ExchangeServiceBuilder : IExchangeServiceBuilder
    {
        private readonly IExchangeCredentialService exchangeCredentialService;
        private readonly IExchangeCredentialEncryption exchangeCredentialEncryption;
        /// <summary>
        /// Initialize service builder
        /// </summary>
        /// <param name="exchangeCredentialService">Credential service</param>
        /// <param name="exchangeCredentialEncryption">Password encryption</param>
        public ExchangeServiceBuilder(IExchangeCredentialService exchangeCredentialService, IExchangeCredentialEncryption exchangeCredentialEncryption)
        {
            this.exchangeCredentialService = exchangeCredentialService;
            this.exchangeCredentialEncryption = exchangeCredentialEncryption;
        }

        /// <summary>
        /// Create new service instance
        /// </summary>
        /// <param name="url">Service url</param>
        /// <param name="userId">Exchange user id</param>
        /// <returns>Service instance</returns>
        public ExchangeService CreateService(string url, long userId)
        {
            var credential = exchangeCredentialService.Get(userId);
            if (credential == null)
                throw new System.Exception($"No exchange credentials for user {userId}");

            NetworkCredential networkCredential = null;

            if (!credential.IsHostedExchange)
            {
                networkCredential = new NetworkCredential(credential.UserName, exchangeCredentialEncryption.Decrypt(credential.Password)
                    , credential.DomainName);
            }
            else
            {
                networkCredential = new NetworkCredential(credential.UserName, exchangeCredentialEncryption.Decrypt(credential.Password));
            }

            ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2010_SP1)
            {
                Url = new Uri(url),
                Credentials = networkCredential
            };

            return service;
        }
    }
}
