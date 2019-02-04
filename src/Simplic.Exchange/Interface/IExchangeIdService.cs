using Microsoft.Exchange.WebServices.Data;
using System;

namespace Simplic.Exchange
{
    /// <summary>
    /// Exchange id service
    /// </summary>
    public interface IExchangeIdService
    {
        /// <summary>
        /// Set item as id
        /// </summary>
        /// <param name="item">Item instance</param>
        /// <param name="id">Unique item id</param>
        void SetId(Item item, Guid id);

        /// <summary>
        /// Search for an item in an exchange mail box
        /// </summary>
        /// <param name="service">Service instance</param>
        /// <param name="id">Unique item id</param>
        /// <returns>Item instance if exists</returns>
        Item GetItem(ExchangeService service, Guid id);
    }
}
