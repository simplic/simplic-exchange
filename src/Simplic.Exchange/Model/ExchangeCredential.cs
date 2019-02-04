using System;

namespace Simplic.Exchange
{
    /// <summary>
    /// Exchange credential
    /// </summary>
    public class ExchangeCredential
    {
        /// <summary>
        /// Gets or sets the ident
        /// </summary>
        public long Ident
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether the user was initialized
        /// </summary>
        public bool WasInitialized
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the domain name
        /// </summary>
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user name
        /// </summary>
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        public byte[] Password
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the internal user id
        /// </summary>
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether the user is active
        /// </summary>
        public bool IsActive
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether to use hosted exchange
        /// </summary>
        public bool IsHostedExchange
        {
            get;
            set;
        }
    }
}