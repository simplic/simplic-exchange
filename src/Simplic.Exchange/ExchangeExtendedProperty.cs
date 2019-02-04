using Microsoft.Exchange.WebServices.Data;

namespace Simplic.Exchange
{
    /// <summary>
    /// Extendend property utilities
    /// </summary>
    public static class ExchangeExtendedProperty
    {
        /// <summary>
        /// Gets the extended property definition name
        /// </summary>
        public const string SimplicIdDefinitionName = "SimplicId";

        /// <summary>
        /// Gets the simplic extended property definition
        /// </summary>
        public static ExtendedPropertyDefinition SimplicIdDefinition
        {
            get;
            set;
        } = new ExtendedPropertyDefinition(DefaultExtendedPropertySet.PublicStrings, SimplicIdDefinitionName, MapiPropertyType.String);
    }
}
