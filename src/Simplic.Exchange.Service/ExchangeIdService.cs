using Microsoft.Exchange.WebServices.Data;
using System;
using System.Linq;

namespace Simplic.Exchange.Service
{
    /// <summary>
    /// Exchange id service
    /// </summary>
    public class ExchangeIdService : IExchangeIdService
    {
        /// <summary>
        /// Set item as id
        /// </summary>
        /// <param name="item">Item instance</param>
        /// <param name="id">Unique item id</param>
        public void SetId(Item item, Guid id)
        {
            item.SetExtendedProperty(ExchangeExtendedProperty.SimplicIdDefinition, id.ToString());
        }

        /// <summary>
        /// Search for an item in an exchange mail box
        /// </summary>
        /// <param name="service">Service instance</param>
        /// <param name="id">Unique item id</param>
        /// <returns>Item instance if exists</returns>
        public Item GetItem(ExchangeService service, Guid id)
        {
            // Create search filter
            var filter = new SearchFilter.IsEqualTo(ExchangeExtendedProperty.SimplicIdDefinition, id.ToString());
            var itemView = new ItemView(1);

            var folders = new[]
            {
                WellKnownFolderName.Root,
                WellKnownFolderName.Calendar,
                WellKnownFolderName.Contacts,
                WellKnownFolderName.Notes,
                WellKnownFolderName.PublicFoldersRoot,
                WellKnownFolderName.Tasks
            };

            // Search entry
            foreach (var folder in folders)
            {
                var result = service.FindItems(folder, filter, itemView);
                if (result.Any())
                {
                    var itemInstance = result.FirstOrDefault();
                    if (itemInstance != null)
                        return itemInstance;
                }
            }

            return null;
        }
    }
}
