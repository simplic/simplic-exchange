using Microsoft.Exchange.WebServices.Data;

namespace Simplic.Exchange
{
    /// <summary>
    /// Exchange service builder
    /// </summary>
    public interface IExchangeServiceBuilder
    {
        /// <summary>
        /// Create new service instance
        /// </summary>
        /// <param name="url">Service url</param>
        /// <param name="userId">Exchange user id</param>
        /// <returns>Service instance</returns>
        ExchangeService CreateService(string url, long userId);
    }
}
