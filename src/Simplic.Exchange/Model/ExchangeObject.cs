using System;

namespace Simplic.Exchange
{
    /// <summary>
    /// Exchange object reference
    /// </summary>
    public class ExchangeObject
    {
        /// <summary>
        /// Gets or sets the item id
        /// </summary>
        public long Ident
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the object id
        /// </summary>
        public string ExchangeObjectId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the stack id
        /// </summary>
        public Guid StackGuid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the instance data id
        /// </summary>
        public Guid InstanceDataGuid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the object status
        /// </summary>
        public ObjectStatus ObjectStatus
        {
            get;
            set;
        }
    }
}